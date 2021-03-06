﻿namespace DotSee
{
    /// <summary>
    /// Holds rules for automatically creating nodes.
    /// </summary>
    public class AutoNodeRule
    {
        public string CreatedDocTypeAlias { get; set; }
        public string DocTypeAliasToCreate { get; set; }
        public string NodeName { get; set; }
        public bool BringNewNodeFirst { get; set; }
        public bool OnlyCreateIfNoChildren { get; set; }

        /// <summary>
        /// Creates a new rule for automatically creating nodes.
        /// </summary>
        /// <param name="createdDocTypealias">The document type Alias to look for. The rule will apply when a document of this type is published.</param>
        /// <param name="docTypeAliasToCreate">The document type to automatically create</param>
        /// <param name="nodeName">The name of the newly created document</param>
        /// <param name="bringNodeFirst">If this is set, then the node will be sorted in order to be first (as opposed to the default last position)</param>
        /// <param name="onlyCreateIfNoChildren">If this is set to true, then the new node will only be created if the node published hasn't already got any child nodes.</param>
        public AutoNodeRule(string createdDocTypealias, string docTypeAliasToCreate, string nodeName, bool bringNodeFirst = false, bool onlyCreateIfNoChildren = false)
        {
            CreatedDocTypeAlias = createdDocTypealias;
            DocTypeAliasToCreate = docTypeAliasToCreate;
            NodeName = nodeName;
            BringNewNodeFirst = bringNodeFirst;
            OnlyCreateIfNoChildren = onlyCreateIfNoChildren;
        }
    }
}
