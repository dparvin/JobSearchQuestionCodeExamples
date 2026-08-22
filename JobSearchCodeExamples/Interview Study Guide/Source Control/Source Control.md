# Source Control Guide
Source control, also called version control, is a system for
managing changes to files over time. It records the history of
changes, allowing developers to see what changed, when it changed,
and who made the change.

Source control allows developers to review previous versions,
compare changes, restore earlier versions, and work on changes
without losing the existing version of the code.

Modern source control systems also provide features that support
collaboration, such as branching, merging, and sharing changes
between developers.

Source control can be implemented using centralized or distributed
version control systems. Git is an example of a distributed version
control system, while older systems such as Microsoft Visual
SourceSafe and Team Foundation Version Control (TFVC) use a more
centralized model.

## Topics
- [Source Control History](#source-control-history)
- [Centralized vs. Distributed Source Control](#centralized-vs-distributed-source-control)
- [Repositories](#repositories)
- [Changes and History](#changes-and-history)
- [Branching and Merging](#branching-and-merging)
- [Current Source Control Options](#current-source-control-options)
- [Personal Experience](#personal-experience)

## Source Control History
Source control has evolved as software development has changed from
individual developers working on local files to large teams working
on shared codebases.

Early source control systems primarily focused on keeping multiple
versions of files and allowing developers to recover previous
versions. As development teams grew, source control systems added
features for coordinating changes made by multiple developers.

### Early Source Control
Early source control systems were generally centralized. A central
server stored the source files and their history, and developers
worked with files managed by that server.

Systems such as Microsoft Delta and Microsoft Visual SourceSafe are
examples of older source control systems from this era.

### Centralized Version Control
Centralized version control systems expanded the capabilities of
earlier systems by providing more sophisticated version history,
branching, merging, and team collaboration.

Microsoft Team Foundation Version Control (TFVC) is an example of a
centralized version control system.

In a centralized system, the central server is the primary location 
for the source files and their history.

### Distributed Version Control
Distributed version control changed the model by giving each
developer a complete copy of the repository, including its history.

Git is the most widely used example of a distributed version control
system.

A developer can create commits, examine history, create branches,
and perform many other source control operations without being
connected to a central server. A remote repository can then be used
to share changes with other developers.

### Modern Source Control Platforms
Modern development platforms provide much more than source control.
They combine repositories with tools for collaboration, code review,
issue tracking, automation, and project management.

Examples include GitHub and Azure DevOps.

These platforms commonly use Git repositories, although Azure DevOps
also supports Microsoft's Team Foundation Version Control (TFVC).

The underlying source control system and the platform providing
services around that system are related but are not necessarily the
same thing.

## Centralized vs. Distributed Source Control

### Centralized Source Control

Centralized source control is a source control system where the
files and their history are maintained in a central storage
location.

Developers work with files managed by the central source control
system. When changes are checked in, the changes and their history
are stored in the central location.

Other developers can then retrieve those changes from the central
location.

```text
             Central Repository
                    |
          +---------+---------+
          |         |         |
          v         v         v
      Developer  Developer  Developer
```

The terminology used for the central storage location has changed
between source control systems. Modern systems commonly use the term
**repository**, but older systems may use different terminology.

Examples of centralized source control systems include Microsoft
Visual SourceSafe and Team Foundation Version Control (TFVC).

### Distributed Source Control
Distributed source control uses a different model. Each developer
has a local copy of the source control data, including the history
of the changes.

A remote storage location can be used as a common place for
developers to share their changes, but the local copy contains its
own source control history.

Developers can make changes and commit them to their local source
control system. They can later send those changes to a remote
location and retrieve changes made by other developers.

```text
        Developer A              Developer B
        Local Repo               Local Repo
             |                        |
             |                        |
             +------ Remote Repo -----+
```

Git is an example of a distributed source control system.

## Repositories
A repository is the collection of source files and source control
information that is managed by a source control system.

A repository normally contains the current version of the files as
well as the history of changes made to those files. Depending on the
source control system, the repository may also contain information
about branches, tags, users, permissions, and other source control
metadata.

The way a repository is stored and accessed depends on the source
control system being used.

### Centralized Repositories
In a centralized source control system, the repository is maintained
in a central location.

Developers work with files managed by the central repository and
communicate with the central source control server when retrieving
or submitting changes.

The central repository is the primary location containing the
history of the source code.

### Distributed Repositories
In a distributed source control system, each developer has a local
repository.

The local repository contains the source files and their source
control history. Developers can make commits and examine the history
without needing to communicate with a remote repository.

A remote repository can be used to share changes between developers.

Git is an example of a distributed source control system.

### Local and Remote Repositories
A distributed source control system can have both local and remote
repositories.

The local repository is the repository on a developer's computer.
The remote repository is a repository that is accessible to multiple
developers and is commonly used to share changes.

Changes can be transferred between repositories. In Git, this is
commonly done using operations such as `push`, `fetch`, and `pull`.

A remote repository is not necessarily the original or authoritative
copy of the source code. Multiple repositories can contain the same
history, and different repositories can be used for different
purposes.

For example:

```text
Developer A                  Developer B
Local Repository             Local Repository
      |                            |
      |                            |
      +---------- Remote ----------+
                  Repository
```

### Repository History
One of the most important purposes of a repository is preserving the
history of the source code.

This history allows developers to:

- See what changes were made
- Determine who made a change
- Determine when a change was made
- Compare different versions
- Restore previous versions
- Investigate when a problem was introduced
- Understand how the code evolved over time

### Repository Terminology
Different source control systems use different terminology for
repositories and the operations performed on them.

For example, older centralized systems may refer to the central
location using terminology other than "repository." Similarly,
centralized systems commonly use the term **check in**, while Git
uses the term **commit** for recording a change in a repository.

The underlying concepts are similar, but the terminology and workflow
depend on the source control system.

### How Repositories Are Stored
The physical storage of source control data depends on the source
control system.

For example, Microsoft Visual SourceSafe stored source control data
as files in a directory structure. Developers using SourceSafe
needed access to the location containing those files through the
SourceSafe client.

Team Foundation Server used a different architecture. TFS provided
a server-based source control system, with source control data
managed by the TFS server and stored in SQL Server.

Modern distributed systems such as Git use yet another model. A Git
repository is a collection of files and metadata stored locally,
normally within a `.git` directory. A remote Git repository can be
hosted on another computer or by a service such as GitHub or Azure
DevOps.

The concept of a repository is therefore independent of the physical
technology used to store it.

## Changes and History
One of the primary purposes of source control is to record changes
made to the source code over time.

When a developer makes changes to files, the source control system
records those changes as part of the history of the source code.

The exact terminology and workflow varies between source control
systems. Centralized systems such as Visual SourceSafe and Team
Foundation Version Control commonly use the term **check in**, while
Git uses the term **commit**.

### Submitting Changes
Source control systems use different terminology for recording
changes. This guide uses the generic term **submitting changes**
when discussing source control concepts that apply to multiple
systems.

For example, Team Foundation Version Control uses the term
**check in**, while Git uses the term **commit**. These operations
have differences in how they work, but both record changes in the
source control system.

### Check In and Commit
A check in or commit records a set of changes in the source control
system.

A change can include modifications to existing files, new files, or
files that have been removed.

A recorded change normally includes information such as:

- The files that were changed
- What was changed
- The person who made the change
- When the change was made
- A description or comment explaining the change

The terminology and details vary between source control systems.

In a centralized system, checking in changes generally sends those
changes to the central source control system.

In a distributed system such as Git, committing changes records them
in the local repository. The changes can later be pushed to a remote
repository to share them with other developers.

### Recording Changes
When changes are submitted to source control, the source control
system has to determine what has changed and incorporate those
changes into the repository.

The system compares the changes being submitted with the appropriate
existing version in the source control system. This allows it to 
identify the changes that have been made and determine whether those 
changes conflict with changes made by someone else.

If there are conflicts, the source control system may require the
developer to resolve them before the changes can be recorded.

Once the changes have been accepted, the source control system
records the change in its history and establishes a new version of
the files.

The exact way this information is stored depends on the source
control system. The repository may store complete versions of files,
differences between versions, or a combination of techniques.

The important concept is that source control maintains both the
current state of the files and enough historical information to
reconstruct and compare previous states.

### Grouping Changes
When several files are changed as part of the same task, source
control systems provide a way to identify those changes as a logical
group when reviewing the history.

The way this group is identified depends on the source control system.

In Microsoft Visual SourceSafe, each file has its own version number.
If three files are checked in together, each file receives its own
new version number. The files are associated with the same logical
change through the check-in operation and its comment.

For example:

```text
File A     Version 15
File B     Version 23
File C     Version 8
```

These files could all have been checked in together as part of the
same change, even though their individual version numbers are
different.

Team Foundation Version Control uses a different model. A check-in
creates a **changeset**, which identifies the group of changes made
to the repository.

Git similarly uses a commit to identify a group of changes made to 
the repository.

For example:
```text
Visual SourceSafe

    File A -> Version 15
    File B -> Version 23
    File C -> Version 8
              |
              +-- Same check-in operation
                  Check-in comment describes the change


TFVC

    File A
    File B
    File C
       |
       +-- Changeset 12345


Git

    File A
    File B
    File C
       |
       +-- Commit abc123...
```

The important distinction is that a file version identifies the
version of an individual file, while a **changeset** or **commit**
identifies a logical group of changes made to multiple files.

When reviewing source control history, the **changeset** or **commit**
can therefore be used to see which files were changed together as 
part of the same logical change.

### Viewing History
Source control maintains a history of changes made to the files in
the repository.

Developers can use this history to:

- Determine when a change was made
- Determine who made a change
- Review previous versions of files
- Compare changes between versions
- Understand how the code evolved
- Investigate when a problem was introduced
- Restore or recover previous versions of files

The history can be particularly useful when investigating a problem
that was not present in an earlier version of the software.

### Comparing Changes
Source control systems provide tools for comparing different
versions of files.

A comparison, commonly called a **diff**, shows the differences
between two versions of a file.

For example:

```text
Previous Version             Current Version

total = price + tax          total = price + tax + shipping
```

A diff can help developers understand exactly what changed rather
than having to compare complete copies of the files.

### Change Sets
Some source control systems group related file changes together
into a single logical change.

For example, changing a feature might require modifications to
several source files:

``` text
Customer.cs
CustomerRepository.cs
CustomerService.cs
CustomerTests.cs
```

The source control system can record these changes together so that
the history shows them as one logical change.

The terminology for this grouping depends on the source control
system. For example, Team Foundation Version Control uses the term
changeset, while Git records related changes as a commit.

### Why History Matters
Source control history is more than a backup of previous versions.

It provides information about how the software was developed and
why the code looks the way it does.

When investigating an unexpected change, a developer can use the
history to determine:

1. When the change was introduced.
2. What files were changed.
3. Who made the change.
4. What other changes were made at the same time.
5. What the developer's change description says about the reason 
   for the change.

This can make source control history an important debugging and
maintenance tool.

## Branching and Merging
Branching allows developers to create a separate line of development
from an existing version of the source code.

A branch can be used to make changes without immediately changing the
main line of development.

### Why Use Branches?
Branches can be used for many purposes, including:

- Developing a new feature
- Fixing a bug
- Experimenting with a change
- Preparing a release
- Allowing multiple developers to work on different changes at the
  same time

For example:

```text
                 Feature Branch
                /
---------------+---------------- Main Branch
```

A developer can make changes on the feature branch while the main
branch continues to represent the existing version of the software.

### Merging
Merging combines changes from one branch into another branch.

For example:
```text
                 Feature Branch
                /       \
---------------+---------+--------- Main Branch
                          ^
                       Merge
```
After the merge, the changes made on the feature branch become part
of the target branch.

### Merge Conflicts
A merge conflict can occur when changes made on different branches
affect the same part of a file in incompatible ways.

For example, two developers might make different changes to the same
line:

```text
Developer A:
total = price + tax

Developer B:
total = price + tax + shipping
```
The source control system may not be able to determine which change
should be retained.

The developer must resolve the conflict and determine what the
resulting code should contain.

### Branching Strategies
Different development teams use different branching strategies.

Some teams maintain a long-lived main or development branch and
create temporary feature branches.

Other teams use branches for releases, maintenance, or hotfixes.

The appropriate strategy depends on the size of the development team,
the release process, and the needs of the project.

The details of creating, merging, and managing branches vary between
source control systems.

## Current Source Control Options
Modern software development uses several different source control
systems and platforms.

It is useful to distinguish between the source control system itself
and the platform that provides services around that system.

For example, Git is a distributed source control system. GitHub
provides hosted Git repositories along with services such as code
review, pull requests, issue tracking, and automation.

Azure DevOps provides development and project-management services,
including both Git repositories and Team Foundation Version Control
(TFVC).

There are many source control systems and development platforms
available today. The following are the systems and platforms that I
have personal or professional experience using.

### Git
Git is a distributed version control system.

Git stores the repository and its history locally, allowing
developers to create commits, examine history, create branches, and
perform many other operations without requiring a connection to a
remote server.

Git can use remote repositories to share changes between developers.

See [Git Guide](./Git/Git.md) for more information.

### GitHub
GitHub is a hosted development platform built around Git.

GitHub provides hosted Git repositories along with features such as:

- Pull requests
- Code review
- Issues
- Actions
- Project management
- Collaboration

GitHub is therefore more than a source control system itself. It
provides services around Git repositories.

See [GitHub Guide](./GitHub/GitHub.md) for more information.

### Azure DevOps
Azure DevOps is a development platform that provides several tools
for software development and project management.

Its source control capabilities include:

- Git repositories
- Team Foundation Version Control (TFVC)

Azure DevOps can also provide work tracking, pull requests, code
review, build automation, release automation, and other development
services.

See [Azure DevOps Guide](./Azure%20DevOps/Azure%20DevOps.md) for more
information.

## Personal Experience
I have been using version control and source control systems for
more than 40 years.

For my personal projects, my first source control system was
Microsoft Delta. I later moved to Microsoft Visual SourceSafe and
then to Microsoft's hosted Team Foundation service, which later
became Visual Studio Team Services (VSTS) and eventually Azure
DevOps Services. More recently, I have been using Git and GitHub.

At Cougar Mountain Software, we used Microsoft Visual SourceSafe,
then moved on to Microsoft's Team Foundation Server (TFS), where I
used Team Foundation Version Control (TFVC) and later Azure DevOps
Server.

My experience includes both centralized and distributed source
control systems and gives me a practical perspective on how source
control has evolved over the course of my career.
