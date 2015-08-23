/* Task Description */
/* 
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */
//function solve() {
//    var library = (function () {
//        var books = [];
//        var categories = [];
//
//        function listBooks(bookProperty) {
//            // check if empty array
//            if (books.length === 0) {
//                return books;
//            }
//            if (bookProperty !== undefined) {
//                // check if sorting by certain category
//                if (bookProperty.category !== undefined) {
//                    return books.filter(function (book) {
//                        if (book.category === bookProperty.category) {
//                            return book;
//                        }
//                    });
//                }
//                // check if sorting by certain author
//                if (bookProperty.author !== undefined) {
//                    return books.filter(function (book) {
//                        if (book.author === bookProperty.author) {
//                            return book;
//                        }
//                    });
//                }
//            }
//            return books;
//        }
//
//        function addBook(book) {
//            var
//                titleDuplication = function (title) {
//                    var i,
//                        len;
//                    for(i = 0, len = books.length; i < len; i += 1) {
//                        if (books[i].title === title) {
//                            return true;
//                        }
//                    }
//                },
//                lengthValidation = function (len, minLen, maxLen) {
//                    if(len < minLen || len > maxLen) {
//                        return false;
//                    }
//                    return true;
//                },
//                checkISBNLength = function(currentISBN){
//                    if(currentISBN.length !== 10 && currentISBN.length !== 13) {
//                        return false;
//                    }
//                    return true;
//                },
//                checkISBNUniqueness = function(currentISBN) {
//                    var i,
//                        len;
//                    for(i = 0, len = books.length; i < len; i += 1) {
//                        if(books[i].isbn === currentISBN) {
//                            return false;
//                        }
//                        return true;
//                    }
//                };
//
//            book.ID = books.length + 1;
//
//            if(!book.author) {
//                throw new Error('Author name cannot be null or empty!');
//            }
//            if(titleDuplication(book.title)) {
//                throw new Error('Title is not unique!');
//            }
//            if(lengthValidation(book.title.length, 2, 100)){
//                throw new Error('Title must be between 2 and 100 characters!')
//            }
//            if(!checkISBNUniqueness(book.isbn)) {
//                throw new Error('ISBN is not unique!');
//            }
//            if(!titleDuplication(book.isbn)) {
//                throw new Error('Incorrect ISBN length!')
//            }
//            books.push(book);
//            if(!(categories.indexOf(book.category) > -1)) {
//                if(!titleDuplication(book.category) && //lengthValidation(book.category)) {
//                    var category = book.category;
//                    category.ID = categories.length + 1;
//                    categories.push(category);
//                }
//            }
//            return book;
//        }
//
//        function listCategories() {
//            return categories;
//        }
//
//        return {
//            books: {
//                list: listBooks,
//                add: addBook
//            },
//            categories: {
//                list: listCategories
//            }
//        };
//    }());
//    return library;
//}
//module.exports = solve;

function solve() {
    var library = (function () {
        var books = [];
        var categories = [];

        function listBooks(bookProperty) {
            if (books.length === 0) {
                return books;
            }
            if (bookProperty !== undefined) {
                if (bookProperty.category !== undefined) {
                    return books.filter(function (book) {
                        if (book.category === bookProperty.category) {
                            return book;
                        }
                    });
                }
                if (bookProperty.author !== undefined) {
                    return books.filter(function (book) {
                        if (book.author === bookProperty.author) {
                            return book;
                        }
                    });
                }
            }
            return books;
        }

        function addBook(book) {
            book.ID = books.length + 1;
            if (checkTitleAndCategory(book.title)) {
                throw new Error('Title is not unique!');
            }
            if (!(book.author.length > 0)) {
                throw new Error('Author name cannot be null or empty!');
            }
            var tempISBN = book.isbn;
            if (checkUniqueISBN(tempISBN)) {
                throw new Error('ISBN is not unique!');
            }
            books.push(book);
            if (!(categories.indexOf(book.category) > -1)) {
                if (!checkTitleAndCategory(book.category)) {
                    var category = book.category;
                    category.ID = categories.length + 1;
                    categories.push(category);
                }
            }
            return book;
        }

        function checkUniqueISBN(tempISBN) {
            var i, len;
            if (tempISBN.length != 10 && tempISBN.length != 13) {
                return true;
            }

            for (i = 0, len = books.length; i < len; i += 1) {
                if (books[i].isbn === tempISBN) {
                    return true;
                }
            }
            return false;
        }

        function checkTitleAndCategory(title) {
            var i, len;
            if (!(title.length > 2 && title.length < 101)) {
                return true;
            }
            for (i = 0, len = books.length; i < len; i += 1) {
                if (books[i].title === title) {
                    return true;
                }
            }
            return false;
        }

        function listCategories() {
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}
module.exports = solve;