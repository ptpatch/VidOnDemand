namespace VidOnDemand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'84749ead-e3fd-4c07-8289-72f06a3907bd', N'admin2@gmail.com', 0, N'AEGjxBBsWeEYX/I01btkmLVtRqv//+aH5nogiVvm1FSZBHF3VKIn/j1acMwqIqTiYw==', N'bb4f8d30-f1d6-4baf-8b85-f492280fa1d3', NULL, 0, 0, NULL, 1, 0, N'admin2@gmail.com')
            INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'ad1b3b66-0102-482a-ab0f-4ab918e3c4c3', N'guest@gmail.com', 0, N'ALhePuBnafvnDZBSCJBhzCNww/tAf7fs1xOoKOiG7nKv5/VkVKrqGIl02zVb+9oL6g==', N'7a935137-060b-4a3b-8896-8bad929ae32b', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a16cd57b-a510-4791-b8cd-0bfc599233a1', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'84749ead-e3fd-4c07-8289-72f06a3907bd', N'a16cd57b-a510-4791-b8cd-0bfc599233a1')
            ");
        }

        public override void Down()
        {
        }
    }
}
