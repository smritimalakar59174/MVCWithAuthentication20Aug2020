namespace MovieCustomerCodeEFWithAuthentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembership : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into MembershipTypes(SignupFree,DurationMonths,DiscountRate) values(0,0,0)");
            Sql("Insert Into MembershipTypes(SignupFree,DurationMonths,DiscountRate) values(30,1,10)");
            Sql("Insert Into MembershipTypes(SignupFree,DurationMonths,DiscountRate) values(90,3,15)");
            Sql("Insert Into MembershipTypes(SignupFree,DurationMonths,DiscountRate) values(300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
