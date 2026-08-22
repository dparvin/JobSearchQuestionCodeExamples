# Git Commits Guide
A commit is a recorded snapshot of the state of a Git repository at
a particular point in its history. A commit identifies the changes
relative to its parent commit and records the state of the files
included in that snapshot.

A commit is created from the changes currently in the staging area:

```text
Working Directory
       |
       | git add
       v
Staging Area
       |
       | git commit
       v
Commit
       |
       v
Repository History
```

A basic commit can be created with:

```bash
git commit -m "Add customer lookup"
```

The `-m` option provides a message describing the changes.

## Topics
- [What a Commit Contains](#what-a-commit-contains)
- [Commit History](#commit-history)
- [Commit Identifiers](#commit-identifiers)
- [Commit Messages](#commit-messages)
- [Commits and the Remote Repository](#commits-and-the-remote-repository)

## What a Commit Contains
A Git commit contains information that identifies the change and
connects it to the repository's history. This includes information
such as:

- A snapshot of the repository's tracked files
- The author of the change
- The date and time of the change
- A commit message
- The parent commit or commits

The parent commit links the new commit to the previous history of the
repository.

A normal commit has one parent, while a merge commit can have two or
more parents.

## Commit History
Commits form a history of changes to the repository.

For example:
```text
Commit A
   |
   v
Commit B
   |
   v
Commit C
   |
   v
Commit D
```

Each commit represents a state of the repository at a particular
point in its history.

A developer can examine this history using:
```bash
git log
```

The history can be used to determine what changes were made, when
they were made, and who made them.

## Commit Identifiers
Each Git commit has an identifier based on the contents of the commit
and the information associated with it.

A commit identifier is commonly displayed as a hexadecimal value,
such as:

```text
a4f7c9d8e2b1...
```

Git normally displays a shortened version of the identifier when
there is enough information to uniquely identify the commit.

For example:
```text
a4f7c9d Add customer lookup
```

The commit identifier can be used to refer to a specific commit when
examining history or performing other Git operations.

## Commit Messages
A commit message should describe the purpose of the change.

For example:
```text
Add customer lookup validation
```

is generally more useful than:
```text
Changes
```

A useful commit message makes the history easier to understand when
the changes are reviewed later.

## Commits and the Remote Repository
A commit is initially recorded in the local repository. Creating a
commit does not automatically send it to a remote repository.

A commit can later be sent to a remote repository using:
```bash
git push
```

When changes are pushed, Git transfers the commits and other repository
objects that are not already present in the remote repository and
updates the remote branch to point to the last commit applied.

For example, if the remote contains commits A and B while the local
repository contains A through D:

```text
Local Repository              Remote Repository

Commit A 
   |     
Commit B 
   |     
Commit C -------------------> Commit C
   |                              |
Commit D ------- push ------> Commit D
```

The remote does not need to receive commits that it already has.

## Common Interview Questions

## My Experience