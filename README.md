# bluefragments-challenge-200

This repos contain a series of level 200 challenges.

To solve one or more challenges, you need to fork the repos to your own GitHub repos, solve the challenges of your preferences and invite https://github.com/blue-challenge-master to the repos.

The challenges should be solved in a language of your preference but either C# or Python is preferred.

If you have any questions or need any help with the challenges, don't hesitate to reach out to challenge@bluefragments.com.

## challenge-201

Usually when you sign up for an account to buy something, your credit card number, phone number or answer to a secret question is partially obscured in some way. Since someone could look over your shoulder, you don't want that shown on your screen. Hence, the website masks these strings.

Your task is to create a function that takes a string, transforms all but the last four characters into "#" and returns the new masked string.

Examples:  
Maskify("4556364607935616") ➞ "############5616"  
Maskify("64607935616") ➞ "#######5616"  
Maskify("1") ➞ "1"  
Maskify("") ➞ ""  

## challenge-202

Create a function that takes a positive integer and returns a string expressing how the number can be made by multiplying powers of its prime factors.

ExpressFactors(2) ➞ "2"  
ExpressFactors(4) ➞ "2^2"  
ExpressFactors(10) ➞ "2 x 5"  
ExpressFactors(60) ➞ "2^2 x 3 x 5"  

## challenge-203

Create a function that finds a target number in a list of prime numbers. Implement a binary search algorithm in your function. The target number will be from 2 through 97. If the target is prime then return "yes" else return "no".

Examples:
int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 }  
IsPrime(primes, 3) ➞ "yes"  
IsPrime(primes, 4) ➞ "no"  
IsPrime(primes, 67) ➞ "yes"  
IsPrime(primes, 36) ➞ "no"  

## challenge-204

Create a function to return the amount of potatoes there are in a string.

Examples:  
Potatoes("potato") ➞ 1  
Potatoes("potatopotato") ➞ 2  
Potatoes("potatoapple") ➞ 1  

## challenge-205

Create two functions that take a string and an array and returns a coded or decoded message.

The first letter of the string, or the first element of the array represents the Character Code of that letter. The next elements are the differences between the characters: e.g. A +3 --> C or z -1 --> y.

Examples:  
Encrypt("Hello") ➞ [72, 29, 7, 0, 3]  
// H = 72, the difference between the H and e is 29 (upper- and lowercase).  
// The difference between the two l's is obviously 0.  
Decrypt([ 72, 33, -73, 84, -12, -3, 13, -13, -68 ]) ➞ "Hi there!"  
Encrypt("Sunshine") ➞ [83, 34, -7, 5, -11, 1, 5, -9]  