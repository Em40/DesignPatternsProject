using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.ChooseMenu
{
    class WorkersMenu
    {
        internal List<ChooseMenuItem> GetWorkersMenuItems()
        {
            return new List<ChooseMenuItem>
            {
                new ChooseMenuItem
                {
                    ItemText = "Menu-All projects for creating websites1",
                    SubItems = new List<ChooseMenuItem>
                    {
                        new ChooseMenuItem
                        {
                            ItemText = "Trading Website11"
                        },

                        new ChooseMenuItem
                        {
                            ItemText = "E-Shop Website12"
                        }
                    }
                },

                new ChooseMenuItem
                {
                    ItemText = "Menu-All projects for creating apps2",
                    SubItems = new List<ChooseMenuItem>
                    {
                        new ChooseMenuItem
                        {
                            ItemText = "App (Messanger)21"
                        },

                        new ChooseMenuItem
                        {
                            ItemText = "App (Instagram)22"
                        }
                    }
                }
            };
        }
    }
}

