Changes made:
1. CalculatorEngine class:
   - Implemented methods for addition, subtraction, multiplication, division, and modulus operations.
   - Added exception handling for division by zero and unsupported operations.

2. InputConverter class:
   - Created a static class with a method to convert string input to numeric values.
   - Added error handling to ensure valid numeric input.

3. Program class:
   - Implemented input validation for numbers and operations.
   - Integrated the `CalculatorEngine` class through a DLL for modularity.

4. DLL integration:
   - Moved `CalculatorEngine` class to a separate Class Library project.
   - Created a DLL and referenced it in the main project.
