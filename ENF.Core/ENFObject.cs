using System.Collections.Generic;

namespace ENF.Core {

    /// <summary>
    /// Serves as the base ENF Object type.
    /// </summary>
    public class ENFObject {

        #region Standard Fields that Every ENF Object will Have

        public string FileName { get; set; }

        /* etc */

        #endregion

        /// <summary>
        /// Additional non-statndard fields can be found here.
        /// </summary>
        public List<ENFField> ExtendedFields { get; set; }
    }

    
}
