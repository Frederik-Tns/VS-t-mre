using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel;

namespace LavNytProjekt_UnitTest
{
    [TestClass]
    public class LavNytProjectUnitTest1
    {
        ProjectRepository projectRepo;
        List<Project> testList;
        Project pro1, pro2, pro3;
        [TestInitialize]
        public void Initialize()
        {
            projectRepo = new ProjectRepository();
            testList = new List<Project>();
        }
        [TestMethod]
        public void AddToRepository()
        {
            // Arrange
            //pro1 = new Project("Fix tag hos F�tex", 799.99, "F�texVej, 5000 Odense C", "Taget er r�dent og skal laves. Der skal bruges en del materialer.");
            //pro2 = new Project("Fix tag hos Fakta", 1099.99, "FaktaVej, 5000 Odense C", "Hele shoppen er r�dden fordi Fakta ikke findes mere.");
            //pro3 = new Project("Fix tag hos Netto", 1199.99, "NettoVej, 5000 Odense C", "Taget er r�dent og skal laves. Der skal bruges en smule materialer.");
            //projectRepo.Add(pro1);
            //projectRepo.Add(pro2);
            //projectRepo.Add(pro3);

            //List<Project> testList = new List<Project>();
            //testList.Add(pro1);
            //testList.Add(pro2);
            //testList.Add(pro3);

            // Act
            List<Project> projectsInRepo = projectRepo.GetAll();
            testList = projectRepo.GetAll();

            // Assert
            Assert.AreEqual(testList.Count, projectsInRepo.Count);
            
            
            
            //CollectionAssert.AreEqual(testList, projectsInRepo);

        }
    }
}