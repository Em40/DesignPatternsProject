using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternProject.ChooseMenu
{
    class ClientsMenu
    {
        internal List<ChooseMenuItem> GetClientsMenuItems()
        {
            return new List<ChooseMenuItem>
            {
                new ChooseMenuItem
                {
                    ItemText = "Menu-Example project for website1",
                    SubItems = new List<ChooseMenuItem>
                    {
                        new ChooseMenuItem
                        {
                            ItemText = "Demo Version Of Project For Website11"
                        },

                        new ChooseMenuItem
                        {
                            ItemText = "Demo Version Of Project For Website12"
                        }
                    }
                },

                new ChooseMenuItem
                {
                    ItemText = "Menu-Example project for app2",
                    SubItems = new List<ChooseMenuItem>
                    {
                        new ChooseMenuItem
                        {
                            ItemText = "Demo Version Of Project For App21"
                        },

                        new ChooseMenuItem
                        {
                            ItemText = "Demo Version Of Project For App22"
                        }
                    }
                }
            };
        }
    }
}

