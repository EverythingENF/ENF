namespace ENF.Core {

    /// <summary>
    /// Used to simplify generic field lists and prevent boxing/unboxing.
    /// </summary>
    public abstract class ENFField { }

    /// <summary>
    /// Generic field class used by ENFObjects.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ENFField<T> {

        /// <summary>
        /// Name of the Field.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// We are dealing with fields on a generic level, the value will be returned based on T type.
        /// </summary>
        public T Value { get; set; }

        public ENFField(string name, T value) {
            this.Name = name;
            this.Value = value;
        }
    }
}
