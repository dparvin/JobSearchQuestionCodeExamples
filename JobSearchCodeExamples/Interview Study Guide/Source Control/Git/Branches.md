# Git Branches Guide
A Git branch is a movable reference to a commit in the repository's
history.

Branches allow developers to create separate lines of development
without changing the existing history of another branch.

For example:

```text
A
|
B
|
C
```

A branch can be created from commit C:

```text
A
|
B
|
C <- main
|
D <- feature
```

The `main` and `feature` branches now identify different points in
the repository's history.

## Topics
- [Branches and Commits](#branches-and-commits)
- [Creating a Branch](#creating-a-branch)
- [Switching Branches](#switching-branches)
- [Branches and Divergent Development](#branches-and-divergent-development)
- [Branch Names](#branch-names)
- [Branches and Remote Repositories](#branches-and-remote-repositories)
- [Branches and Merging](#branches-and-merging)
- [Deleting a Branch](#deleting-a-branch)
- [Reusing a Branch Name](#reusing-a-branch-name)
- [Common Interview Questions](#common-interview-questions)
- [My Experience](#my-experience)

## Branches and Commits
A branch does not contain a separate copy of the repository or its
files. It is a reference to a commit.

When a new commit is made while working on a branch, the branch
reference moves to the new commit.

For example:
```text
A
|
B
|
C <- main
|
D <- feature
```

If another commit is made on feature:
```text
A
|
B
|
C <- main
|
D
|
E <- feature
```

If another commit is made on `feature`:

```text
A
|
B
|
C <- main
|
D
|
E <- feature
```

The main branch still points to C, while feature now points to E.

The commits themselves have not moved. The branch references have
moved to identify the newer commits.

## Creating a Branch
A branch can be created with:

```bash
git branch feature
```

This creates a branch named feature at the current commit.

Creating a branch does not automatically switch the working directory
to that branch.

A developer can switch to an existing branch with:

```bash
git switch feature
```

A branch can also be created and checked out in one operation:

```bash
git switch -c feature
```

## Switching Branches
Switching branches changes which branch the developer is currently
working on.

For example:

```text
        feature
           |
A -- B -- C
           |
          main
```

If the developer switches to `feature`, new commits will normally
advance `feature` rather than `main`.

After a commit:

```text
        feature
           |
A -- B -- C -- D
           |
          main
```

The two branches now identify different points in the history.

## Branches and Divergent Development
Branches are commonly used to allow development to proceed
independently.

For example, a developer can create a feature branch from `main`:

```text
A
|
B <- main
|
C <- feature
```

The developer can then continue making commits on the `feature` 
branch without changing where `main` points:

```text
        feature
           |
A -- B -- C -- D
     |
    main
```

Other developers can continue making changes on `main`:

```text
        feature
           |
A -- B -- C -- D
     |
     E -- F <- main
```

The histories have now diverged.

The `feature` branch can later be merged back into `main`.

## Branch Names
Branch names are labels used to identify branches.

Common branch names include:

```text
main
feature/customer-lookup
bugfix/login-error
release/2.5
```

Git does not require these particular names. Branch names are chosen
by the development team according to its workflow.

The name `main` is commonly used for the primary branch, but Git does
not require the primary branch to have that name.

## Branches and Remote Repositories
Branches can exist only in a local repository or can also be shared
through a remote repository.

A local branch can be pushed to a remote repository:

```bash
git push -u origin feature
```

This allows other developers to obtain the branch from the remote
repository.

The local branch and remote branch are related, but they are separate
references.

A developer can therefore have local branches that have never been
pushed to a remote repository.

## Branches and Merging
Branches provide separate lines of development, while merging brings
those lines of development back together.

For example:

```text
        feature
           |
A -- B -- C
     \
      D -- E <- main
```

The histories can later be merged so that the changes from `feature`
are incorporated into `main`.

See [Merging](#merging) for more information.

## Deleting a Branch
A branch can be deleted after its changes have been merged into
another branch.

For example:

```text
        feature
           |
A -- B -- C
     |
    main
```

After `feature` is merged into `main`:

```text
A -- B -- C
          ^
       main, feature
```

The `feature` branch can then be deleted:

```bash
git branch -d feature
```

Deleting a branch removes the branch reference, but does not delete
the commits that are part of the repository's history.

After the branch is deleted:

```text
A -- B -- C
          ^
         main
```

The commits remain accessible through `main`.

A branch can also be force-deleted with:
```bash
git branch -D feature
```

The `-D` option can delete a branch even when Git determines that its
changes have not been merged. This should be used with care because
the branch may be the only reference to commits that have not been
incorporated into another branch.

## Reusing a Branch Name
Once a branch has been deleted, its name can be used for another
branch.

For example, after deleting `feature`:

```text
A -- B -- C
          ^
         main
```

A new branch named `feature` can be created:

```bash
git switch -c feature
```

The new `feature` branch is a new branch reference. It does not
restore or reuse the previous branch itself.

This means a team can use a consistent branch name such as
`feature/customer-lookup` for different pieces of work over time.
Each use of the name can refer to a different set of commits.

## Common Interview Questions

## My Experience
I have used Git branches for development and maintained branches 
in GitHub repositories. At CMS, I primarily worked with Azure DevOps 
Server and TFVC, so my Git experience has been more recent and 
includes maintaining my own GitHub repositories and CI/CD workflows. 
I have used Git branches for development and maintained branches in 
GitHub repositories. At CMS, I primarily worked with Azure DevOps 
Server and TFVC, so my Git experience has been more recent and 
includes maintaining my own GitHub repositories and CI/CD workflows.
