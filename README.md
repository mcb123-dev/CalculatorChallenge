# Calculator Challenge  

## Summary  
Create a calculator that only supports an Add operation given a single formatted string.  

- Provide code via a public distributed version control repository (e.g., GitHub). Do **NOT** fork this repo.  
- Console application using the language defined by your interviewer.  
- Include unit tests.  
- Show each requirement step as a separate commit. Think of each step as a "requirement change."  
- Efficient code is always important, but for this exercise, readability and separation of concerns are much more critical.  
- Excluding stretch goals will not affect your overall assessment, but implementing them poorly will.  

## Requirements  

1. **Support a maximum of 2 numbers using a comma delimiter.** Throw an exception when more than 2 numbers are provided.  
   - Examples:  
     - `20` → returns `20`  
     - `1,5000` → returns `5001`  
     - `4,-3` → returns `1`  
   - Empty input or missing numbers should be converted to `0`.  
   - Invalid numbers should be converted to `0` (e.g., `5,tytyt` → returns `5`).  

2. **Remove the maximum constraint for numbers**  
   - Example: `1,2,3,4,5,6,7,8,9,10,11,12` → returns `78`.  

3. **Support a newline character (`\n`) as an alternative delimiter**  
   - Example: `1\n2,3` → returns `6`.  

4. **Deny negative numbers**  
   - Throw an exception that includes all of the negative numbers provided.  

5. **Make any value greater than 1000 an invalid number**  
   - Example: `2,1001,6` → returns `8`.  

6. **Support 1 custom delimiter of a single character**  
   - Format: `//{delimiter}\n{numbers}`  
   - Examples:  
     - `//#\n2#5` → returns `7`  
     - `//,\n2,ff,100` → returns `102`  
   - All previous formats should also be supported.  

7. **Support 1 custom delimiter of any length**  
   - Format: `//[{delimiter}]\n{numbers}`  
   - Example: `//[***]\n11***22***33` → returns `66`.  
   - All previous formats should also be supported.  

8. **Support multiple delimiters of any length**  
   - Format: `//[{delimiter1}][{delimiter2}]...\n{numbers}`  
   - Example: `//[*][!!][r9r]\n11r9r22*hh*33!!44` → returns `110`.  
   - All previous formats should also be supported.  

## Stretch Goals  

1. **Display the formula used to calculate the result**  
   - Example: `2,,4,rrrr,1001,6` → returns `2+0+4+0+0+6 = 12`.  

2. **Allow the application to process entered entries until `Ctrl+C` is used.**  

3. **Allow the acceptance of arguments to define:**  
   - Alternate delimiter in step #3.  
   - Toggle whether to deny negative numbers in step #4.  
   - Upper bound in step #5.  

4. **Use Dependency Injection (DI).**  

5. **Support subtraction, multiplication, and division operations.**  
