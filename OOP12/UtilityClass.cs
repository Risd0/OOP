namespace OOP12
{
    /// <summary>Presents different useful methods.</summary>
    static class UtilityClass
    {
        /// <summary> Clamps the <c>val</c> number between  <c>min</c> and <c>max</c>. </summary>
        /// <remarks> if max < min then max evaluates min. </remarks>
        /// <param name="min">the minimum of val can be.</param>
        /// <param name="max">the minimum of val can be.</param>
        public static int Clamp(int min, int max, int val)
        {
            if (min > max) { max = min; }
            if (val > max) { val = max; }
            else if (val < min) { val = min; }
            return val;
        }
    }
}