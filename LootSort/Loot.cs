using System;

namespace LootSort
{
    /// <summary>
    /// The Loot class should implement IComparable<Loot>
    /// and override GetHashCode() and Equals()
    /// </summary>
    public class Loot : IComparable<Loot>
    {
        /// <summary>Type of loot.</summary>
        public LootType Kind { get; }

        /// <summary>Loot description.</summary>
        public string Description { get; }

        /// <summary>Loot value.</summary>
        public float Value { get; }

        /// <summary>
        /// Create a new instance of loot.
        /// </summary>
        /// <param name="kind">Type of loot.</param>
        /// <param name="description">Loot description.</param>
        /// <param name="value">Loot value.</param>
        public Loot(LootType kind, string description, float value)
        {
            Kind = kind;
            Description = description;
            Value = value;
        }

        /// <summary>
        /// Return a nicely formatted string representing the loot instance.
        /// </summary>
        /// <returns>
        /// A nicely formatted string representing the loot instance.
        /// </returns>
        public override string ToString() =>
            $"[{Kind,15}]\t{Value:f2}\t{Description}";

        /// <summary>
        /// Compare all the loot and organize them accordingly.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Loot other)
        {
            if (other == null) return 1;

            //IMPORTANT: Ordinals gives the position of something in a list.
            //This will be used to sort the loot alphabetically 
            int typeComparison = string.Compare(Kind.ToString(), 
            other.Kind.ToString(), StringComparison.Ordinal);

            //Compares the type of loot
            if (typeComparison != 0)
                return typeComparison;

            //If loot types are the same, compare values
            int valueComparison = Value.CompareTo(other.Value);
            //Depending on the value comparison:
            if (valueComparison != 0)
                //Sort between high and low values.
                return -valueComparison; 
            //If they are the same then sort them alphabetically.
            return string.Compare(Description, other.Description, 
            StringComparison.Ordinal);
        }
    }
}