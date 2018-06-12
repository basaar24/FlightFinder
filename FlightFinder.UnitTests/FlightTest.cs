using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightFinder.UnitTests
{
    using DataInterfaces;
    using BusinessLayer;
    using Web.Controllers;
    using Types;

    [TestClass]
    public class FlightTest
    {
        [TestMethod]
        public void FlightGetAllShouldReturnAllFlights()
        {
            // Arrange
            var mockFlightsRepository = new Mock<IFlightsRepository>();
            var flightsProcessor = new FlightsProcessor(mockFlightsRepository.Object);
            var enumerable = new List<FlightDto>();

            // Act
            mockFlightsRepository.Setup(mock => mock.GetAll())
                                    .ReturnsAsync(enumerable);

            //Assert
            Assert.IsNotNull(flightsProcessor.GetAll());
            mockFlightsRepository.Verify(x => x.GetAll(), Times.Once());
        }
    }
}
