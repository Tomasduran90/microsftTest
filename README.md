# Microsoft Dictionary



## Explanation

The dictionary interface that is in charge of validating and loading the dictionary has a file-based implementation. This dictionary is injected into the service, 
which together with the class of permutations solves the algorithm and returns the list of words in English. Also we have a mehtod to calculate the complexity of
the word,  this could be use to make or not  the calc base on the number of possiblites that the word has.

### Design

- A Dictionary implementation for file load, this contains the list of words and the method to validate words.
- A Service implementation that inject the IDictonary and use the permutations methods to resolve the algorithm
- Program class show the way we can use the class with the implementation and a word to test


