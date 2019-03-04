from django.shortcuts import render, redirect
from apps.login_app.models import User
from .models import Book
from django.contrib import messages
from django.core.urlresolvers import reverse

# Create your views here.


def books(request):
    print("*"*90)
    print("got to books")
    context = {
        'user_info': User.objects.get(id=request.session['id']),
        'books_query': Book.objects.all(),

    }
    return render(request, "books_app/index.html", context)


def add_books(request):
    print("*"*90)
    print("adding a book")
    errors = Book.objects.add_validator(request.POST)
    print(errors)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
            return redirect(reverse('books'))
    else:
        user_info = User.objects.get(id=request.session['id'])
        new_book = Book.objects.create(title=request.POST['title'], description=request.POST['form_desc'], uploaded_by=user_info)
        print("Book Added")
        print(new_book)
        new_book.user_like.add(user_info)
        return redirect(reverse("books_app:books"))


def fav_book(request, id):
    print("*"*90)
    print("Fav book")
    book_info = Book.objects.get(id=id)
    user_info = User.objects.get(id=request.session['id'])
    print(user_info.fname)
    book_info.user_like.add(user_info)
    print(book_info.user_like.all())
    return redirect(reverse('books_app:books'))



def single_book(request,id):
    print("*"*90)
    print("got to a book page")
    context = {
        "book_info": Book.objects.get(id=id)
    }
    return render(request, "books_app/book.html", context)
