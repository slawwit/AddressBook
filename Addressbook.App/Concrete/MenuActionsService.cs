using System;
using Addressbook.App.Common;
using Addressbook.Domain.Entity;

namespace Addressbook.App.Concrete
{
    public class MenuActionsService : BaseService<MenuActions>
    {
        public MenuActionsService()
        {
            Initialize();
        }
        public List<MenuActions> GetMenuActions()
        {
            List<MenuActions> result = new List<MenuActions>();
            foreach (var menuAction in Items)
            {
                result.Add(menuAction);
            }
            return result;
        }

        private void Initialize()
        {
            AddItem(new MenuActions(1, "Add new person."));
            AddItem(new MenuActions(2, "Remove person."));
            AddItem(new MenuActions(3, "Show all persons."));
            AddItem(new MenuActions(4, "Show details of person with given id."));
            AddItem(new MenuActions(0, "Exit."));
        }
    }
}
