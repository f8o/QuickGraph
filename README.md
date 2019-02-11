### What is going on:

- Forked from YC.QuickGraph.
- Removed all non core functionality in order to build for netstandard/.netcore.
- Added one unit test for Dijkstra shortest paths (original unit tests depend on PEX which is .net fx full compat only).

### Original README:

# QuickGraph [![NuGet Status](http://img.shields.io/nuget/v/YC.QuickGraph.svg?style=flat)](https://www.nuget.org/packages/YC.QuickGraph/)

QuickGraph provides generic directed/undirected graph datastructures and algorithms for .NET.

QuickGraph comes with algorithms such as depth first seach, breath first search, A* search, shortest path, k-shortest path, maximum flow, minimum spanning tree, etc.

*QuickGraph was originally created by Jonathan "Peli" de Halleux in 2003.*

Branch | .NET |
---| ---
Master | [![master .NET Build Status](https://img.shields.io/appveyor/ci/gsvgit/quickgraph/master.svg)](https://ci.appveyor.com/project/gsvgit/quickgraph) |
GraphTasks | [![GraphTasks .NET Build Status](https://img.shields.io/appveyor/ci/gsvgit/quickgraph/GraphTasks.svg)](https://ci.appveyor.com/project/gsvgit/quickgraph) |

## Contributing

### Build

* Clone this repo.
* Install Pex from lib/Pex.
* Install CodeContracts from lib/DotNet.CodeContracts.
* Use build.cmd for build.
* Use Visual Studio 2015 for development.

### Where to go next?

* [Documentation](https://quickgraph.codeplex.com/documentation)

### Maintainer(s)

* [@gsvgit](https://github.com/gsvgit)
