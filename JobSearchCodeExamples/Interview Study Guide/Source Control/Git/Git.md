# Git Guide
Git is a distributed version control system used to manage changes
to source code and other files. Git maintains a history of changes
in a repository and allows developers to work with that history
locally.

Unlike centralized source control systems, Git gives each developer
a local copy of the repository, including its history. This allows
many source control operations to be performed without being
connected to a remote server.

Git uses commits to record changes, branches to provide separate
lines of development, and merging to combine changes from different
branches. Git also provides a staging area that allows developers to
select which changes will be included in a commit.

Git can work with remote repositories to allow developers to share
changes with other developers. Commands such as `fetch`, `pull`, and
`push` are used to exchange changes between local and remote
repositories.

This guide focuses on Git-specific concepts and commands. General
source control concepts such as version history, repositories,
branching, merging, and centralized versus distributed source
control are covered in the [Source Control Guide](../Source%20Control/Source%20Control.md).

The guide also compares Git with Team Foundation Version Control
(TFVC) and GitHub, and includes common Git topics that may be useful
when preparing for software development interviews.

## Topics
- [What Is Git?](#what-is-git)
- [Repositories](Repositories.md)
- [Remote Repositories](Remote%20Repositories.md)
- [Stash](Stash.md)
- [Working Directory and Staging Area](Working%20Directory%20and%20Staging%20Area.md)
- [Commits](Commits.md)
- [Branches](Branches.md)
- [Merging](Merging.md)
- [Rebasing](Rebasing.md)
- [Fetch, Pull, and Push](Fetch%20Pull%20and%20Push.md)
- [Tags](Tags.md)
- [Undoing Changes](Undoing Changes.md)
- [Resolving Merge Conflicts](Resolving%20Merge%20Conflicts.md)
- [Configuration](Configuration.md)
- [Workflow](Workflow.md)
- [Git vs. TFVC](Git vs TFVC.md)
- [Git vs. GitHub](Git vs GitHub.md)
- [Common Interview Questions](#common-interview-questions)
- [My Experience](#my-experience)

## What Is Git?
Git is a distributed version control system used to track changes
to files and manage the history of those changes.

Git was originally created by Linus Torvalds in 2005 to support the
development of the Linux kernel. It was designed to support a large,
distributed development effort where many developers could work on
the same codebase.

Unlike centralized source control systems, Git does not require a
central server for normal source control operations. Each Git
repository contains the source files and the history needed to work
with the repository locally.

A developer can create commits, examine history, create branches,
compare changes, and perform many other Git operations without being
connected to a remote repository.

Remote repositories are commonly used to share changes between
developers and provide a common location for collaboration. However,
the remote repository is not required for Git's basic source control
operations.

For complete documentation of Git commands and features, see the
[official Git documentation](https://git-scm.com/doc).

### Git and Remote Hosting Platforms
Git is the source control system. Services such as GitHub and Azure
DevOps provide development platforms that can host Git repositories
and provide additional development and collaboration features.

For example, Git provides commands such as:

```text
git add
git commit
git branch
git merge
git fetch
git pull
git push
```

These commands operate on Git repositories. A hosting platform can
provide additional services around those repositories, such as pull
requests, code review, issue tracking, permissions, and automated
builds.

Git and GitHub are therefore not the same thing. Git is the
distributed version control system, while GitHub is a platform that
provides hosting and collaboration services built around Git.

## Common Interview Questions

## My Experience