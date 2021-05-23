namespace MovieRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedAdminAndRole : DbMigration
    {
        public override void Up()
        {
               Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'8a79e096-052b-4057-9683-7a7443aa305a', N'admin@mail.com', 0, N'AGrshXn4aDpENGAszAdRiFmMx2v3SfnG4Uq/sWU36YSLPRukoFW1Ku5U9y2KTx8OaQ==', N'491ec367-08f3-44cb-a5da-eea484bf034c', NULL, 0, 0, NULL, 1, 0, N'admin@mail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b38fafbd-3156-440a-88ab-851b2433fefc', N'guest@MovieRent.com', 0, N'AAW9NIqUYk2fzp4xEofrNRiTM0FFUYrdZvL86YXBk4OVCjikqSAWUQytHgek+Cl4yA==', N'bb97d846-7e91-4b40-a1cd-94e996ffa47c', NULL, 0, 0, NULL, 1, 0, N'guest@MovieRent.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'df696c9b-fa26-4f46-b2b1-ad753ea50361', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8a79e096-052b-4057-9683-7a7443aa305a', N'df696c9b-fa26-4f46-b2b1-ad753ea50361')
");
        }

public override void Down()
        {
        }
    }
}
