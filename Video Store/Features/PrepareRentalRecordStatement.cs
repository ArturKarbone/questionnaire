using System;
using Shouldly;
using Video_Store.Domain;
using Xunit;

namespace Video_Store.Features
{
    class PrepareRentalRecordStatement
    {
        public string Hanlde(Customer customer)
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;

            string result = $"Rental record for {customer.FullName}\r\n";
            foreach (var rental in customer.Rentals)
            {
                double thisAmount = 0;
                switch (rental.Movie.MovieType)
                {
                    case MovieType.Regular:
                        {
                            thisAmount += 2;
                            if (rental.DaysRented > 2)
                            {
                                thisAmount += (rental.DaysRented - 2) * 1.5;
                            }
                            break;
                        }
                    case MovieType.NewRelease:
                        {
                            thisAmount += rental.DaysRented * 3;
                            if (rental.DaysRented > 1)
                            {
                                frequentRenterPoints++;
                            }
                            break;
                        }
                    case MovieType.Children:
                        {
                            thisAmount += 1.5;
                            if (rental.DaysRented > 3)
                            {
                                thisAmount += (rental.DaysRented - 3) * 1.5;
                            }
                            break;
                        }
                }

                frequentRenterPoints++;
                result += $"{rental.Movie.Title}. Owed : {thisAmount} EUR\r\n";
                totalAmount += thisAmount;
            }

            result += $"You owed: {totalAmount} EUR\r\n";
            result += $"You earned: {frequentRenterPoints} bonus points\r\n";

            return result;
        }
    }

    public class PrepareStatementTests
    {
        [Fact]
        public void Should_prepare_rental_statement_correctly()
        {
            //arrange/act
            var statement = new PrepareRentalRecordStatement().Hanlde(BuildCustomerWithRentalHistory());
            //assert
            statement.ShouldBe(ExpectedStatement());
        }

        private string ExpectedStatement() => 
            @"Rental record for Bruce Jenkins
Fighting with My Family. Owed : 9 EUR
Long Shot. Owed : 12 EUR
Toy Story 4. Owed : 7.5 EUR
The Wolf of Wall Street. Owed : 18.5 EUR
You owed: 47 EUR
You earned: 6 bonus points
";

        private Customer BuildCustomerWithRentalHistory() => new Customer()
        {
            FirstName = "Bruce",
            LastName = "Jenkins",
            Rentals =
                 {
                    new Rental()
                    {
                        Movie = new Movie()
                        {
                            Title = "Fighting with My Family",
                            MovieType = MovieType.NewRelease
                        },
                        RentedAt = DateTime.Parse("2019-04-01"),
                        ReturnedAt = DateTime.Parse("2019-04-01")
                            .AddDays(3)
                    },
                    new Rental()
                    {
                        Movie = new Movie()
                        {
                            Title = "Long Shot",
                            MovieType = MovieType.NewRelease
                        },
                        RentedAt = DateTime.Parse("2019-04-02"),
                        ReturnedAt = DateTime.Parse("2019-04-03")
                            .AddDays(3)
                    },
                    new Rental()
                    {
                        Movie = new Movie()
                        {
                            Title = "Toy Story 4",
                            MovieType = MovieType.Children
                        },
                        RentedAt = DateTime.Parse("2019-04-05"),
                        ReturnedAt = DateTime.Parse("2019-04-09")
                            .AddDays(3)
                    },
                    new Rental()
                    {
                        Movie = new Movie()
                        {
                            Title = "The Wolf of Wall Street",
                            MovieType = MovieType.Regular
                        },
                        RentedAt = DateTime.Parse("2019-04-15"),
                        ReturnedAt = DateTime.Parse("2019-04-25")
                            .AddDays(3)
                    }
                }
        };
    }
}
