# Git Remote Repositories Guide
A remote repository is another Git repository that is used to share
source code and changes between developers or to provide a central
location for collaboration.

A remote repository is separate from the local Git repository. A
developer can make commits in the local repository without being
connected to the remote repository.

Remote repositories are commonly hosted by platforms such as GitHub
or Azure DevOps, although a remote repository can be hosted in other
locations as well.

A local repository can have one or more remote repositories
associated with it.

## Topics
- [Origin](#origin)
- [Sharing Changes](#sharing-changes)
- [Multiple Remote Repositories](#multiple-remote-repositories)
- [Remote Repository and Hosting Platform](#remote-repository-and-hosting-platform)
- [Common Interview Questions](#common-interview-questions)
- [My Experience](#my-experience)

## Origin
When a repository is cloned, Git normally creates a remote named
`origin` that refers to the repository from which it was cloned.

For example:

```text
Local Repository
       |
       | origin
       v
Remote Repository
```

`origin` is simply the default name Git gives to the remote. It is
not a special type of remote repository, and the name can be changed
or additional remotes can be added.

To see the names of the remotes associated with a repository, use:

``` bash
git remote
```
or for more information:
``` bash
git remote -v
```

## Sharing Changes
Changes can be exchanged between a local repository and a remote
repository.

A developer can retrieve changes from a remote repository using
`fetch` or `pull`, and can send local commits to a remote repository
using `push`.

```text
                 Remote Repository
                    /        \
                 fetch       push
                  /            \
                 v              ^
          Local Repository
```

The local repository maintains its own history. Sending changes to a
remote repository does not make the remote repository part of the
local repository; it sends commits from the local repository to the
remote repository.

## Multiple Remote Repositories
A Git repository can have more than one remote repository.

For example, a developer might have:

```text
origin  -> company repository
upstream -> original open-source repository
```
This can be useful when contributing to an open-source project or
when working with repositories that have multiple sources of changes.

The names of remotes are configurable. `origin` and `upstream` are
common names, but Git does not require these names.

## Remote Repository and Hosting Platform
A remote repository is a Git concept, while the service hosting the
repository may provide additional functionality.

For example, GitHub and Azure DevOps can host Git repositories and
provide additional features such as pull requests, code review,
permissions, issue tracking, and automated builds.

The Git repository and the hosting platform should therefore be
considered separate concepts.

## Common Interview Questions

## My Experience
