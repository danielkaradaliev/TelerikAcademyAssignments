/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(numbers) {
	var sum = 0,
		len,
		i;
	len = numbers.length;

	if(len === 0) {
		return null;
	}

	for(i = 0; i < len; i += 1) {
		if(isNaN(numbers[i])) {
			throw new Error;
		}

		numbers[i] = numbers[i] | 0;
		sum += numbers[i];
	}

	return sum;
}

//var numbers = ["1", "2"];
//console.log(sum(numbers));
module.exports = sum;