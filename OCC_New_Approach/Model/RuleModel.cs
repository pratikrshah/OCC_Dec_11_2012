using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace OCC_New_Approach
{
    public class RuleModel
    {
        public Rule ruleDetails { get; set; }
        public Message displayMessage { get; set; }
        public RuleProvision rulePrivisionDetails { get; set; }
        //public RuleDerieved ruleDerievedDetails { get; set; }

        public EmailClassification classificationDetails { get; set; }
        public Recipients recipDetails { get; set; }                /** These are plural **/
        public Attachments attachmentDetails { get; set; }          /** These are plural **/
    }

    public class Rule
    {
        public int ruleName { get; set; }
        public string ruleDescription { get; set; }
        public Enum blockType {get; set;}
    }

    public enum blockType
    {
        HardBlock,
        SoftBlock,
        MoveAndSend
    }

    public class Message
    {
        public string topMessage { get; set; }
        public string bottomMessage { get; set; }
        public string hypLink { get; set; }
    }

    public class RuleProvision
    {
        public string RP_Requestor { get; set; }
        public string RP_Group { get; set; }
    }

    public class RuleDerieved
    {
        public string blockImage
        {
            get;

            set;
            //{
            //    return "/Resource/Images/" + /**blockType**/ +".png";
            //}
        }
        public Color windowShade { get; set; }
    }

    public class EmailClassification
    {
        public string defaultClassification { get; set; }
        public Dictionary<string, bool> classificationvalues { get; set; }
    }

    public class Recipients
    {
        public int recipCount { get; set; }
        public List<Recipient> recipList { get; set; }
    }

    public class Recipient
    {
        public string recipName { get; set; }
        public string domainName { get; set; }
    }

    public class Attachments
    {
        public int attachmentCount { get; set; }
        public List<Attachment> attachList;
    }

    public class Attachment
    {
        public string attachmentName { get; set; }
        public bool isHiddenSheets { get; set; }
        public bool isHiddenColumns { get; set; }
        public bool isHiddenRows { get; set; }
        public string readPassword { get; set; }
        public string writePassword { get; set; }
    }
}
