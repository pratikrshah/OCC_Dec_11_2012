using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace OCC_New_Approach
{
    public class BorderShadingTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {

            

            FrameworkElement element = container as FrameworkElement;

            return element.FindResource("RuleTypeSoftBlockDataTemplate") as DataTemplate;

            //if (element != null && item != null && item is RuleViewModel)
            //{
            //    RuleViewModel ruleViewModel = item as RuleViewModel;

            //    if (true)
            //        return element.FindResource("RuleTypeHardBlockDataTemplate") as DataTemplate;
            //    //if (ruleViewModel.ruleDetails.blockType == 2)
            //    //    return element.FindResource("RuleTypeSoftBlockDataTemplate") as DataTemplate;
            //    //if (ruleViewModel.ruleDetails.blockType == 3)
            //    //    return element.FindResource("RuleTypeModifySendDataTemplate") as DataTemplate;
            //}

            //return null;
        }
    }
}
