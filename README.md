[![BCH compliance](https://bettercodehub.com/edge/badge/motri/Vending_Machine_Tech_Test?branch=master)](https://bettercodehub.com/)
![travis-ci](https://travis-ci.org/motri/Vending_Machine_Tech_Test.svg?branch=master)

## Vending Machine Tech Test
The aim of this tech test is to emulate the behavior of a vending machine.

In this case the machine only takes 50 pence coins, only sells water(60p) and crisps(40p) and returns the right amount of change owed plus the list of "bought" items.
This program was written to be interacted with through the command line.

### Table of contents
* [Quickstart](https://github.com/motri/Vending_Machine_Tech_Test#quickstart)
* [Tests](https://github.com/motri/Vending_Machine_Tech_Test#tests)
* [Tech](https://github.com/motri/Vending_Machine_Tech_Test#tech)
* [Diagram](https://github.com/motri/Vending_Machine_Tech_Test#diagram)

### Quickstart
First, clone this repository. Then:

```
open the command line
navigate to folder .../VendingMachineTechTest/VendingMachineTechTest
run mono Project.exe
```
or
```
open project using Visual Studio
compile and run
```

### Tests
To run the tests in Visual Studio:
```
open project folder in VS
click run
click on run unit tests
```
![Passing tests](https://www.imageupload.co.uk/images/2017/07/12/Capturadepantalla2017-07-12alas2.27.50.png)

(please be aware currency based tests might fail depending on your systems location)

### Tech
* C#
* .NET
* NUnit for unit testing
* Travis-CI for continuos integration


### Diagram
![Class diagram](http://res.cloudinary.com/motri/image/upload/v1499823308/20170712_020431_bdzeeq.jpg)
