from django.shortcuts import render, redirect
from .models import Book, Author

# Create your views here.
def index(request):
    print("*"*90)
    context = {
        "book_table": Book.objects.all()
    }
    return render(request, "tables/index.html", context)

def authors(request):
    print("*"*90)
    context = {
        "author_table": Author.objects.all()
    }
    return render(request, "tables/authors.html", context)

def book(request, id):
    num = int(id)
    context = {
        "a_book": Book.objects.get(id=num),
        "all_author": Author.objects.exclude(books=num)
    }
    print("*"*90)
    print(context)
    return render(request, "tables/book.html", context)

def author(request, id):
    num = int(id)
    context = {
        "an_author": Author.objects.get(id=num),
        "all_book": Book.objects.exclude(authors=num)
    }
    return render(request, "tables/one_author.html", context)

def add_book(request):
    print("*"*90)
    print("got to add book")
    add_title = request.POST['title']
    add_desc = request.POST['description']
    print(add_title)
    new_book = Book.objects.create(title = add_title, desc = add_desc)
    print(new_book)
    num = new_book.id
    print(num)
    return redirect(f"/books/{num}")

def add_author(request):
    add_fname = request.POST['fname']
    add_lname = request.POST['lname']
    add_note = request.POST['notes']
    new_author = Author.objects.create(fname = add_fname, lname = add_lname, notes = add_note)
    num = new_author.id
    return redirect(f"/authors/{num}")
    
def add_author_to_book(request, id):
    num = int(id)
    print("*"*90)
    print("adding author to book list")
    add_author = request.POST['add_author']
    author_fname, author_lname = add_author.split(" ")
    the_author = Author.objects.get(fname = author_fname, lname=author_lname)
    update_book = Book.objects.get(id=num)
    update_book.authors.add(the_author)
    return redirect(f"/books/{num}")

def add_book_to_author(request, id):
    num = int(id)
    print("*"*90)
    print("Adding book to author list")
    add_book = request.POST['add_book']
    print(add_book)
    the_book = Book.objects.get(title=add_book)
    update_author = Author.objects.get(id=num)
    update_author.books.add(the_book)
    return redirect(f"/authors/{num}")