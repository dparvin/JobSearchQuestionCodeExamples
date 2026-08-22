# Git Working Directory and Staging Area Guide
Git uses a staging area to allow a developer to select which changes
will be included in the next commit.

The `working directory` contains the files that the developer is
currently working on. Changes made to these files are initially
changes to the working directory and are not automatically included
in the next commit.

The `staging area`, also called the `index`, contains the changes
that have been selected to be included in the next commit.

This provides a separation between changes that have been made and
changes that are ready to be committed.

For example:

```text
Working Directory
      |
      | git add
      v
Staging Area
      |
      | git commit
      v
Repository
```

## Topics
- [Working Directory](#working-directory)
- [Staging Area](#staging-area)
- [Changes Made After Staging](#changes-made-after-staging)
- [Viewing Staged and Unstaged Changes](#viewing-staged-and-unstaged-changes)
- [Staging and TFVC](#staging-and-tfvc)
- [Common Interview Questions](#common-interview-questions)
- [My Experience](#my-experience)

## Working Directory
The working directory is the current set of files being worked on.

When a developer modifies a tracked file, Git can determine that the
working directory version differs from the version recorded by Git.

The change remains in the working directory until it is either
staged, discarded, or otherwise handled by the developer.

## Staging Area
The staging area allows a developer to select specific changes for
the next commit.

A change can be staged using:

```bash
git add <file>
```

Once a change has been staged, Git uses the staged version of that
change when creating the next commit.

A developer can stage some files while leaving other modified files
unstaged.

For example:
```text
Working Directory

Customer.cs          modified
CustomerService.cs   modified
CustomerTests.cs     modified
```

The developer could stage only two of the files:

```bash
git add Customer.cs CustomerTests.cs
```

The next commit would contain the staged changes, while the changes
to `CustomerService.cs` would remain in the working directory.

In Git, a commit records the changes that are currently in the
staging area. Changes remaining only in the working directory are 
not included in that commit.

## Changes Made After Staging
The staging area contains the specific version of the changes that
were staged.

If a developer stages a file and then modifies the file again, the
new modifications are not automatically added to the staging area.

For example:
```text
1. Modify Customer.cs
2. git add Customer.cs
3. Modify Customer.cs again
```

At this point, the staging area contains the version of
`Customer.cs` from step 2, while the working directory contains the
additional changes made in step 3.

The developer must stage the file again if those additional changes
should be included in the next commit.

This allows a developer to separate changes to the same file into
different commits.

## Viewing Staged and Unstaged Changes
Git provides commands for examining the changes in the working
directory and staging area.

For example:

```bash
git status
```

shows which files have been modified, staged, or otherwise changed.

The differences in the working directory that have not been staged
can be viewed with:

```bash
git diff
```

The differences that have been staged for the next commit can be
viewed with:

```bash
git diff --staged
```

## Staging and TFVC
The Git staging area provides some functionality that is similar to
the include/exclude process in TFVC.

Both allow a developer to select which changes will be included in a
submission.

The Git staging area is more explicit, however. Git maintains a
specific staged version of the changes, separate from subsequent
changes made to the working directory.

For example:

```text
Working Directory
    |
    | git add
    v
Staging Area
    |
    | git commit
    v
Repository
```

This separation is an important difference between Git's working 
model and the working models used by centralized source control 
systems such as TFVC.

## Common Interview Questions

## My Experience
