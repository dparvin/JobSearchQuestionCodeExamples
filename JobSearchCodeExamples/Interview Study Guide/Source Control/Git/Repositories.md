# Git Repositories Guide
A Git repository is the location where Git stores the files and
information needed to manage a project's source code and its history.

A Git repository contains the project's files as well as the
information Git uses to track changes, commits, branches, tags, and
other repository information.

A Git repository can exist entirely on a developer's local computer.
It does not require a remote server.

A repository can also have one or more remote repositories associated
with it. Remote repositories are commonly used to share changes
between developers or to provide a central location for collaboration.

## Topics
- [Creating a Repository](#creating-a-repository)
- [The .git Directory](#the-git-directory)
- [Local and Remote Repositories](#local-and-remote-repositories)
- [Common Interview Questions](#common-interview-questions)
- [My Experience](#my-experience)

## Creating a Repository
A new Git repository can be created in an existing directory by
running:

```text
git init
```

This creates the Git repository information needed to begin tracking
the files in that directory.

An existing remote repository can instead be copied to a local
computer using:

```text
git clone <repository>
```

Cloning creates a local repository containing the files and history
from the remote repository.

## The `.git` Directory
When `git init` is used, Git creates a hidden `.git` directory inside
the working directory.

The `.git` directory contains the information Git uses to manage the
repository, including its history, references, configuration, and
other internal data.

The working files that make up the project are normally stored 
outside the `.git` directory. The `.git` directory contains Git's 
information about those files rather than being the location where 
the project files themselves are normally edited.

For example:
```text
MyProject/
|
+-- .git/
|   +-- Git repository data
|
+-- Program.cs
+-- MyProject.csproj
+-- README.md
```
The `.git` directory is what makes the directory a Git repository.

## Local and Remote Repositories
A local repository and a remote repository are separate Git
repositories.

For example:
```text
Developer Computer
    |
    +-- Working Directory
    |
    +-- Local Git Repository
             |
             | push / fetch
             v
       Remote Git Repository
```

The local repository contains its own history. Changes can be
committed locally without immediately sending them to a remote
repository.

Remote repositories are covered in more detail in 
[Remote Repositories](Remote%20Repositories.md).

## Common Interview Questions
- What is a Git repository?
- What is the difference between a local and remote repository?
- What is the purpose of the `.git` directory?

## My Experience
I have experience working with repositories in both Azure DevOps 
Server and Azure DevOps Services.

At Cougar Mountain Software, I worked with Azure DevOps Server, 
which CMS used for its source control and development processes. 
CMS used TFVC repositories rather than Git repositories.

I have also used Azure DevOps Services for personal processes. Some 
of my Azure DevOps Services projects use Git repositories, while 
others use TFVC repositories. This has given me practical experience 
with both source control models within the Azure DevOps ecosystem.

I have used Azure DevOps Services build pipelines with source code 
stored in GitHub. One of these processes builds the source code, 
runs the unit tests, and packages the resulting library as a NuGet 
package.

The build process also generates code coverage reports and publishes 
them to GitHub Pages. It generates documentation for the resulting 
code and publishes that documentation to a GitHub Wiki.

I also maintain several Git repositories on GitHub for personal 
projects and interview preparation. These include C#, C++, F#, and 
VB.NET projects, as well as my Interview Study Guide.

My Git experience includes creating repositories with `git init`, 
cloning existing repositories with `git clone`, working with local 
and remote repositories, creating branches, committing changes, 
merging branches, using stashes, and working with GitHub Actions 
for automated builds and testing.

My experience with both TFVC and Git has given me a practical 
understanding of the differences between centralized and distributed 
source control.