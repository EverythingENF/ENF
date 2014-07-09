namespace ENF.Core {
    
    /// <summary>
    /// Proof of Concept Class
    /// Class to handle the reading and writing operations of an ENF object.
    /// </summary>
    public static class Encoding {
        
        /// <summary>
        /// Proof of Concept Method
        /// Static class method to generate an ENF object from a native file. Returns an ENF object.
        /// </summary>
        public static ENFObject CreateENFObjectFromFile(string nativeFileFullPath) {

            // TODO: Add code to generate an enf object from the file system.  Note: Will place the object in memory.

            return new ENFObject();
        }

        /// <summary>
        /// Proof of Concept Method
        /// Static class method to read an ENF file from the file system. Returns an ENF object.
        /// </summary>
        public static ENFObject ReadENFObjectFromFile(string enfFileFullPath) {
            
            // TODO: Add code to read an enf file from the file system.

            return new ENFObject();
        }
    }
}
