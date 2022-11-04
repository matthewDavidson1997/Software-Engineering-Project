using System;
using System.Windows.Forms;

namespace Relationship_manager_administration_system
{ 
	public class User
	{
		public int id;
		public string username;
		public string password;
		public string role;

		public User(int id, string username, string password, string role){
			this.id = id;
			this.username = username;
			this.password = password;
			this.role = role;
		}
	}
}