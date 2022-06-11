using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.ChooseMenu
{
    class BossMenu
    {
        internal List<ChooseMenuItem> GetBossMenuItems()
        {
            return new List<ChooseMenuItem>
            {
                new ChooseMenuItem
                {
                    ItemText = "Menu-All types of sites1",
                    SubItems = new List<ChooseMenuItem>
                    {
                        new ChooseMenuItem
                        {
                            ItemText = "New suggestions for site11"
                        },

                        new ChooseMenuItem
                        {
                            ItemText = "New suggestions for site12"
                        }
                    }
                },

                new ChooseMenuItem
                {
                    ItemText = "Menu-All types of apps2",
                    SubItems = new List<ChooseMenuItem>
                    {
                        new ChooseMenuItem
                        {
                            ItemText = "New suggestions for apps21"
                        },

                        new ChooseMenuItem
                        {
                            ItemText = "New suggestions for apps22"
                        }
                    }
                }
            };
        }
    }
}

