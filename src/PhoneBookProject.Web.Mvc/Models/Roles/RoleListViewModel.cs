﻿using System.Collections.Generic;
using PhoneBookProject.Roles.Dto;

namespace PhoneBookProject.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}