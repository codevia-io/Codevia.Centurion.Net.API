﻿namespace Entities.Interfaces
{
    public interface IUser
	{
		public string FirsName { get; set; }
		public string? LastName { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public int? Telephone { get; set; }
	}
}

