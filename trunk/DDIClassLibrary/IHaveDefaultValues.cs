namespace DDIClassLibrary
{
    /// <summary>
    /// Interface used on classes which have default values.
    /// </summary>
    internal interface IHaveDefaultValues
    {
        /// <summary>
        /// Sets the optional default values.
        /// </summary>
        /// <param name="shouldSet">if set to <c>true</c>, optional default values will be set.</param>
        void SetDefaultValues(bool shouldSet);
    }
}
