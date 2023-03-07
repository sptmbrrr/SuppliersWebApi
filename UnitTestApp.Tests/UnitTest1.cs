using Moq;
using Application.Common.Repository.Interfaces;

namespace UnitTestApp.Tests;

public class UnitTest1
{
    [Fact]
    public void PaginationIsReturnedOnlyNecessaryAmountOfData()
    {
        //Avarage
        var mockRepo = new Mock<ICarRepository>();
        //mockRepo.Setup
        //Act

        //Assert
    }
}