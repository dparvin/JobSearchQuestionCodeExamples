# Git Stash Guide
Git stash provides a way to temporarily save changes in the working
directory without committing those changes.

Stashing is useful when a developer has changes that are not ready to
be committed but needs to temporarily return the working directory
to a clean state.

For example, a developer might be working on a feature when an
urgent problem needs to be fixed. The developer can stash the
unfinished changes, switch to another branch, make the required
changes, and then return to the original work later.

A basic stash operation can be performed with:

```bash
git stash
```

The changes are removed from the working directory and stored in the
repository's stash.

The stashed changes can later be restored with:

```bash
git stash pop
```

`git stash pop` restores the most recent stash and removes it from
the stash list.

A stash can also be restored without removing it from the stash list
by using:

```bash
git stash apply
```

## Topics
- [Stash List](#stash-list)
- [Stash and TFVC Shelvesets](#stash-and-tfvc-shelvesets)
- [Naming and Managing Multiple Stashes](#naming-and-managing-multiple-stashes)
- [Sharing Partially Completed Work](#sharing-partially-completed-work)
- [Common Interview Questions](#common-interview-questions)
- [My Experience](#my-experience)

## Stash List
Git can maintain multiple stashes.

The current stash list can be viewed with:

```bash
git stash list
```

For example:
```text
stash@{0}: WIP on feature-a
stash@{1}: WIP on feature-b
stash@{2}: WIP on main
```

A specific stash can be restored by specifying its name:
```bash
git stash apply stash@{1}
```

## Stash and TFVC Shelvesets
Git stash is similar in purpose to a TFVC shelveset because both
provide a way to temporarily store work that is not ready to be
committed or checked in.

There is an important difference, however. A Git stash is stored in
the local Git repository and is primarily intended for temporarily
saving a developer's own work.

A TFVC shelveset can be stored on the Team Foundation Server and can
be used to make pending changes available to other developers.

Therefore, although both can be used to temporarily set aside
unfinished work, they are not equivalent features.

## Naming and Managing Multiple Stashes

Git can maintain multiple stashes in a repository. Stashes are not
limited to one per branch.

A stash can be given a descriptive message when it is created:

```bash
git stash push -m "Work on customer lookup"
```

The stashes can be viewed with:

```bash
git stash list
```

For example:

```text
stash@{0}: On feature-a: Work on customer lookup
stash@{1}: On feature-a: Fix validation
stash@{2}: On main: Update documentation
```

The message is descriptive text; Git identifies each stash using a
name such as `stash@{0}` or `stash@{1}`.

A specific stash can be restored by specifying its name:

```bash
git stash apply stash@{1}
```

The stash list belongs to the repository rather than to an individual
branch. A stash can therefore be created on one branch and later
applied while working on another branch, although the changes may
need to be resolved if they do not apply cleanly.

The older `git stash save` command can also be used to create a stash
with a message, but `git stash push -m` is the preferred modern
syntax.

## Sharing Partially Completed Work

Git stashes are stored in the local repository and are not sent to
remote repositories when commits are pushed. A stash therefore cannot
normally be used to transfer unfinished work directly to another
developer.

When partially completed work needs to be shared with another
developer, the work can be committed to a branch and the branch can
be pushed to a remote repository.

For example:

```text
Feature Branch
      |
      +-- Commit 1
      |
      +-- Commit 2
      |
      +-- WIP Commit
             |
             | push
             v
      Remote Repository
             |
             | fetch/pull
             v
      Other Developer
```

The commit does not have to represent a completed feature. A
work-in-progress (WIP) commit can be used to transfer partially
completed work to another developer.

The receiving developer can continue working on the branch and add
additional commits. If necessary, the WIP commits can later be
combined, reorganized, or removed from the branch history before the
completed feature is merged.

This provides functionality similar to using a TFVC shelveset to
transfer unfinished work, but Git uses commits and branches rather
than a stash for sharing work between developers.

## Common Interview Questions

- What is Git stash?
- Can you have multiple stashes?
- Are Git stashes stored in the remote repository?
- How is Git stash different from a TFVC shelveset?
- How would you share unfinished work with another developer?

## My Experience
