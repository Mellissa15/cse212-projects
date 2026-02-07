public static class Recursion
{
    /// <summary>
    /// #############
    /// # Problem 1 #
    /// #############
    /// Using recursion, find the sum of 1^2 + 2^2 + 3^2 + ... + n^2
    /// </summary>
    public static int SumSquaresRecursive(int n)
    {
        if (n <= 0)
            return 0;

        return n * n + SumSquaresRecursive(n - 1);
    }

    /// <summary>
    /// #############
    /// # Problem 2 #
    /// #############
    /// Using recursion, insert permutations of length
    /// 'size' from a list of 'letters' into the results list.
    /// </summary>
    public static void PermutationsChoose(List<string> results, string letters, int size, string word = "")
    {
        // Base case
        if (word.Length == size)
        {
            results.Add(word);
            return;
        }

        // Recursive case
        for (int i = 0; i < letters.Length; i++)
        {
            string remaining = letters.Remove(i, 1);
            PermutationsChoose(results, remaining, size, word + letters[i]);
        }
    }

    /// <summary>
    /// #############
    /// # Problem 3 #
    /// #############
    /// Count number of ways to climb stairs using steps of 1, 2, or 3.
    /// Uses memoization.
    /// </summary>
    public static decimal CountWaysToClimb(int s, Dictionary<int, decimal>? remember = null)
    {
        // Base Cases
        if (s == 0)
            return 0;
        if (s == 1)
            return 1;
        if (s == 2)
            return 2;
        if (s == 3)
            return 4;

        // Initialize memo dictionary
        if (remember == null)
            remember = new Dictionary<int, decimal>();

        // Return memoized value if available
        if (remember.ContainsKey(s))
            return remember[s];

        // Recursive calculation
        decimal ways =
            CountWaysToClimb(s - 1, remember) +
            CountWaysToClimb(s - 2, remember) +
            CountWaysToClimb(s - 3, remember);

        // Store and return
        remember[s] = ways;
        return ways;
    }

    /// <summary>
    /// #############
    /// # Problem 4 #
    /// #############
    /// Generate all binary strings from a wildcard pattern.
    /// </summary>
    public static void WildcardBinary(string pattern, List<string> results)
    {
        int index = pattern.IndexOf('*');

        // Base case: no wildcard
        if (index == -1)
        {
            results.Add(pattern);
            return;
        }

        // Replace '*' with '0'
        WildcardBinary(
            pattern[..index] + "0" + pattern[(index + 1)..],
            results
        );

        // Replace '*' with '1'
        WildcardBinary(
            pattern[..index] + "1" + pattern[(index + 1)..],
            results
        );
    }

    /// <summary>
    /// #############

    public static void SolveMaze(List<string> results, Maze maze, int x = 0, int y = 0, List<ValueTuple<int, int>>? currPath = null)
    {
        if (currPath == null)
        {
            currPath = new List<ValueTuple<int, int>>();
        }

        // TODO Start Problem 5
        // ADD CODE HERE

        // results.Add(currPath.AsString());
    }
}
