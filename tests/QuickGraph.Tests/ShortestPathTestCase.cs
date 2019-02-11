using System;
using System.Linq;
using QuickGraph.Algorithms;
using Xunit;

namespace QuickGraph.Tests
{
    public class ShortestPathTestCase
    {
        [Fact]
        public void Dijkstra_implementation_finds_the_shortest_path()
        {
            var graph = new AdjacencyGraph<int, Edge<int>>();
            
            graph.AddVertex(0);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);

            graph.AddEdge(new Edge<int>(0, 1));
            graph.AddEdge(new Edge<int>(1, 2));
            
            graph.AddEdge(new Edge<int>(2, 3)); // should not be included in  shortest paths list
            graph.AddEdge(new Edge<int>(3, 4)); // should not be included in  shortest paths list
            
            graph.AddEdge(new Edge<int>(2, 4));

            var shortestPath = graph.ShortestPathsDijkstra(_ => .0, 0);
            var hasPath = shortestPath(4, out var paths);

            
            Assert.True(hasPath);
            Assert.NotNull(paths);
            
            var indexedPaths = paths as Edge<int>[] ?? paths.ToArray();
            Assert.Equal(3, indexedPaths.Length);
            
            var path = indexedPaths[0];
            Assert.Equal(0, path.Source);
            Assert.Equal(1, path.Target);

            path = indexedPaths[1];
            Assert.Equal(1, path.Source);
            Assert.Equal(2, path.Target);

            path = indexedPaths[2];
            Assert.Equal(2, path.Source);
            Assert.Equal(4, path.Target);
        }
    }
}