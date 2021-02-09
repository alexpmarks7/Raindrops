# Raindrops

A program that checks to see if an integer has 3, 5 and 7 as a factor, and returns a string.  If the integer has 3 as a factor, the string will be "Pling", 5 and it will be "Plang", 7 and it will be "Plong".  If it has both 3 and 7, the string will be "PlingPlang" and so on. If it has none of these are factors,  the programme returns the integer as a string.

Complete with Nunit Tests.  Have checked that 0 returns "PlingPlangPlong", checked for numbers with just 3, 5 and 7 respectively as factors.  Have checked for numbers with a combination of two of the factors returning "PlingPlang" for example, and have checked for numbers with all 3 as factors returning "PlingPlangPlong".  Finally, have checked to see if negative numbers return the correct response.