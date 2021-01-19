using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture, Description("this fixture contains Mars Framework")]
        [Category("Sprint1")]
        class User : Global.Base
        {

            #region Profile page

            
                public void AddProfile()
                {
                   Profile profileobj = new Profile();
                    profileobj.EnterProfile();
                    profileobj.VerifyProfile();
                    
                }

               
                public void EditProfile()
                {
                    Profile profileobj = new Profile();
                    profileobj.EditProfile();
                    profileobj.VerifyEditedProfile();

                }

                
                public void DeleteProfile()
                {
                   Profile profileobj = new Profile();
                    profileobj.DeleteProfile();
                   
    
                }

            #endregion


            #region Skill Share page
            [Test, Description("Check if the user is able to add ShareSkill details successfully")]
                public void EnterShareSkill()
                {
                    ShareSkill shareSkillObj = new ShareSkill();
                    shareSkillObj.EnterShareSkill();
                    shareSkillObj.VerifySkill();
                }

            #endregion

            #region Manage Listing page
            [Test, Description("Check if the user is able to View ManageListing successfully")]
                public void ManageListing()
                {

                    ManageListing manageobj = new ManageListing();
                    manageobj.Listings();

                }

                [Test, Description("Check if the user is able to Edit ManageListing successfully")]
                public void EditManageListing()
                {

                    ManageListing manageobj = new ManageListing();
                    manageobj.EditListings();
                    manageobj.ValidateEditedDetails();
                }

                [Test, Description("Check if the user is able to Delete ManageListing successfully")]
                public void DeleteManageListing()
                {

                    ManageListing manageobj = new ManageListing();
                    manageobj.DeleteListings();
                    manageobj.ValidateDeletedDetails(); 
                }
            #endregion
        }
    }
}