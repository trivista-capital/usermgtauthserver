using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trivister.Core.Entities;

namespace Trivister.DataStore.DbConfigurations;

public class RolesPermissionsConfiguration: IEntityTypeConfiguration<RolesPermission>
{
    public void Configure(EntityTypeBuilder<RolesPermission> builder)
    {
        builder.HasData(new RolesPermission()
            { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 1
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 2
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 3
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 4
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 5
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 6
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 7
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 8
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 9
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 10
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 11
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 12
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 13
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 14
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 15
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 16
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 17
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 18
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 19
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 20
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 21
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 22
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 23
            },
            new { 
                RoleId = Guid.Parse("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), 
                PermissionId = 24
            });
        builder.HasKey(e => new { e.RoleId, e.PermissionId });
    }
}