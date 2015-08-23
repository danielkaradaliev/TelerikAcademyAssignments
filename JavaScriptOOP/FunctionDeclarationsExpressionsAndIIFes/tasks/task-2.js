/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(from, to) {
	var sieve = [],
		i,
		j,
		primes = [];
	if(isNaN(from)) {
		throw new Error;
	}

	if(isNaN(to)) {
		throw new Error;
	}

	if(isNaN(to)) {
		throw new Error;
	}


	//source: http://stackoverflow.com/questions/21795543/how-to-find-prime-numbers-in-entered-number-range
	for (i = 2; i <= to; i += 1) {
		if (!sieve[i]) {
			// i has not been marked -- it is prime
			if (i >= from) {
				primes.push(i);
			}
			for (j = i << 1; j <= to; j += i) {
				sieve[j] = true;
			}
		}
	}
	return primes;
}

module.exports = findPrimes;
