# Git Merging Guide
Merging is the process of combining changes from two different lines
of development into a single history. This can happen when two formal
branches are merged, or when two or more developers have created
divergent histories from the same branch and those histories need to
be brought back together.

In Git, different branches can contain different commits even though
they originally started from the same commit. A merge combines the
histories of those branches.

For example, suppose two developers start with the same commit:

```text
A
|
B
```

One developer creates commit C:

```text
A
|
B
|
C
```

Before C is pushed, another developer creates commit D from B and
pushes it to the remote repository:

```text
A
|
B
|
D
```

The two developers have now created divergent histories that both
started from commit B. When the first developer attempts to push C,
Git cannot simply move the remote branch forward because the remote
contains commit D that is not part of the local history.

The first developer must incorporate the changes from D into the
local history before C can be pushed. If the changes in C and D do
not conflict, Git can automatically combine the changes and create
a new merge commit. If the changes conflict, the developer must
resolve the conflicts before the merge can be completed.

If the first developer merges the remote changes into the local
branch, Git combines the two lines of development by creating a 
new merge commit:

```text
A
|
B
|\
D |
| C
|/
E
```

Commit E has both C and D as parent commits. Neither C nor D is
changed by the merge. The merge commit records the result of
combining the two histories.

## Topics
- [Fast-Forward Merge](#fast-forward-merge)
- [Divergent Merge Without Conflict](#divergent-merge-without-conflict)
- [Merge Conflicts](#merge-conflicts)
- [Completing a Merge](#completing-a-merge)
- [Merging and Remote Repositories](#merging-and-remote-repositories)
- [Common Interview Questions](#common-interview-questions)
- [My Experience](#my-experience)

## Fast-Forward Merge
Not every merge requires a new merge commit.

If branch `feature` is being merged into the current branch, and
`feature` is directly ahead of the current branch, Git can perform
a fast-forward merge.

For example, the current branch has:

```text
A
|
B
```
If branch `feature` was created from B and has commit C:

```text
A
|
B
|\
| C   <- feature
|
main
```

When branch `feature` is merged into `main`, there is no divergent
history to combine. Git can simply move the `main` branch pointer 
from B to C:

```text
A
|
B
|
C   <- main, feature
```
No new merge commit is required.

## Divergent Merge Without Conflict
Suppose two developers start with the same commit:

```text
A
|
B
```

The first developer creates commit C but does not immediately 
push it:

```text
A
|
B
|
C
```

The second developer creates commit D from B and pushes it to the
remote repository:

```text
A
|
B
|
D
```

The two developers have now created different lines of development.
When the first developer later attempts to push C, Git cannot simply
move the remote branch to C because the remote branch contains D.

The first developer must first incorporate D into the local history.

If the changes in C and D do not conflict, Git can automatically
merge the changes:

```text
A
|
B
|\
D |
| C
|/
E
```

Commit E is a merge commit with C and D as its parents.

The merge does not require the developer to manually resolve any
conflicts because Git was able to combine the changes automatically.

## Merge Conflicts
A merge does not necessarily result in a conflict.

A **merge conflict** occurs when Git cannot automatically determine how
to combine changes from the two lines of development.

For example, suppose both C and D modify the same line of a file in
incompatible ways. Git can determine that the histories can be
combined, but it cannot determine which version of the conflicting
change should be used.

The developer must then resolve the conflict before the merge can be
completed.

For example, one branch might change:

```text
total = price + tax
```

to

```text
total = price + tax + shipping
```

while another branch changes the same line to:

```text
total = price + tax + discount
```

Git cannot automatically determine whether the result should contain
`shipping`, `discount`, or both.

The developer must resolve the conflict and then complete the merge.

The important point is that a merge conflict is not a conflict 
between the commits themselves. It is a conflict between changes 
that Git is attempting to combine.

## Completing a Merge
A merge can be started with:

```bash
git merge <branch>
```

If Git can complete the merge automatically, the merge may complete
without requiring manual intervention.

If conflicts occur, the developer must resolve the affected files,
stage the resolved files, and complete the merge.

The resulting merge commit records the combined history.

## Merging and Remote Repositories
Merging can occur entirely in the local repository. A developer can
fetch changes from a remote repository, merge them locally, test the
result, and then push the resulting history to the remote repository.

For example:
```text
Remote Repository
        |
        | fetch
        v
Local Repository
        |
        | merge
        v
Merged History
        |
        | push
        v
Remote Repository
```

This is one of the advantages of Git's distributed model: the
developer can perform the merge and resolve conflicts locally before
sharing the resulting history with other developers.

## Common Interview Questions
- What is a merge?
- What is a fast-forward merge?
- What causes a merge conflict?
- Does merging change the existing commits?
- Where does a merge actually occur?
- What happens when you try to push a branch that has diverged from the remote branch?

## My Experience
