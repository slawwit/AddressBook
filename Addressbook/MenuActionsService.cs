using System;
namespace Addressbook
{
	public class MenuActionsService
	{
        private List<MenuActions> menuActions;
        public MenuActionsService()
        {
            menuActions = new List<MenuActions>();
        }
        
        public List<MenuActions> GetMenuActions()
        {
            AddMenuAction(1, "Add new person.");
            AddMenuAction(2, "Remove person.");
            AddMenuAction(3, "Show all persons.");
            AddMenuAction(4, "Show details of person with given id.");
            return menuActions;

        }

        private void AddMenuAction(int id, string name)
        {
            MenuActions menuAction = new MenuActions() { Id = id, Name = name };
            menuActions.Add(menuAction);
        }
    }
}

