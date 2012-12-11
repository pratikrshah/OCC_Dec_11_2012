using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace OCC_New_Approach
{
    public class RuleViewModel
    {
        #region Feilds
        private ObservableCollection<RuleModel> _rules;
        private Color _shadecolor;
        public myCommand ReturnToEditCommand { get; set; }
        public myCommand SendAsIsCommand { get; set; }
        #endregion

        #region Properties
        public ObservableCollection<RuleModel> rules
        {
            get
            {
                return _rules;
            }
            set
            {
                _rules = value;
            }
        }
        public Color shadecolor
        {
            get
            {
                return _shadecolor;
            }
            set
            {
                _shadecolor = value;
            }
        }
        #endregion

        #region Constructor
        public RuleViewModel()
        {

            #region Populate the rule collection
            _rules = new ObservableCollection<RuleModel>()
            {
                    #region Populating Rule 1
                    new RuleModel()
                    {
                        ruleDetails = new Rule()
                        {
                            ruleName = 400,
                            ruleDescription = "External Recipients Rule",
                            blockType = blockType.SoftBlock
                        },
                        displayMessage = new Message()
                        {
                            topMessage = "This email contains 4 external (Non-GS) recipients. Please ensure that these are intended. Below are the names of the externalr recipients",
                            bottomMessage = "Please Select Send As-Is to continue sending email or else Return To Edit to modify the recipeint list.",
                            hypLink = "http://www.gs.com"
                        },
                        recipDetails = new Recipients()
                        {
                            recipCount = 2,
                            recipList = new List<Recipient>()
                            {
                                new Recipient
                                {
                                    recipName = "aaa@hotmail.com",
                                    domainName = "hotmail.com"
                                },
                                 new Recipient
                                {
                                    recipName = "bbb@yahoo.com",
                                    domainName = "yahoo.com"
                                }
                            }

                        }
                        
                    }
                    #endregion

                    #region Populating Rule 2
                    #endregion
            };
            #endregion

            ReturnToEditCommand = new myCommand(myReturnToEditCommandExecute, myCanReturnToEditCommandExecute);
            SendAsIsCommand = new myCommand(mySendAsIsCommandExecute, myCanSendAsIsCommandExecute);
        }
        #endregion

        private void myReturnToEditCommandExecute(object parameter)
        {

        }

        private bool myCanReturnToEditCommandExecute(object parameter)
        {
            return true;
        }

        private void mySendAsIsCommandExecute(object parameter)
        {

        }

        private bool myCanSendAsIsCommandExecute(object parameter)
        {
            return true;
        }
    }
}
