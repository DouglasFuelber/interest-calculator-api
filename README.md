<h1 align="center">
  Interest Calculator API
</h1>

## Description

This solution has two APIs responsible for calculate the interest based in the initial value and the number of months, given by parameter. The repository contains four projects, two with the APIs, and two more with the projects unit tests. The solution was developed using **.NET Core 5** and the unit tests use **XUnit**.

### InterestRateApi

This is the API project that has an endpoint responsable for return the interest rate value (*/taxajuros*).

### InterestRateApi.UnitTests

This is the project contains the unit tests of the InterestRateApi project.

### InterestCalculatorApi

This is the API project that has an endpoint responsable for calculate the interest, based on the given initial value and number of months (*/calculajuros?valorinicial=100&meses=5*), and with the interest rate obtained from the other API (*/taxajuros*). This project also has a endpoint that returns the URL of the solution repository on GitHub (*/showmethecode*).

### InterestCalculatorApi.UnitTests

This is the project contains the unit tests of the InterestCalculatorApi project.

## How to run

From a terminal instance, run the following commands.

```bash
# Clone this repository
$ git clone https://github.com/DouglasFuelber/interest-calculator-api.git

# Access the solution folder
$ cd interest-calculator-api

# Restore the packages
$ dotnet restore

# Execute the solution Unit Tests 
$ dotnet test
```

### Run InterestRateApi

From the same terminal instance, run the following commands.

```bash
# From the solution folder, access the InterestRateApi folder
$ cd InterestRateApi

# Execute the project 
$ dotnet run
```

After executed this commands, the API will be available in <a href="https://localhost:5001" target="_blank" rel="noopener noreferrer">https://localhost:5001</a>.

In <a href="https://localhost:5001/swagger" target="_blank" rel="noopener noreferrer">https://localhost:5001/swagger</a> we can access a list of all the API endpoints and also test them.

### Run InterestCalculatorApi

From another terminal instance and keeping the InterestRateApi running, execute the following commands.

```bash
# From the solution folder, access the InterestCalculatorApi folder
$ cd InterestCalculatorApi

# Execute the project 
$ dotnet run
```

After executed this commands, the API will be available in <a href="https://localhost:5003" target="_blank" rel="noopener noreferrer">https://localhost:5003</a>.

In <a href="https://localhost:5003/swagger" target="_blank" rel="noopener noreferrer">https://localhost:5003/swagger</a> we can access a list of all the API endpoints and also test them.

