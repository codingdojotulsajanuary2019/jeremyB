from django.conf.urls import url
from . import views

urlpatterns = [
    url(r'^books$', views.books, name='books'),
    url(r'^books/(?P<id>\d+)$', views.single_book, name="single_book"),
    url(r'^books/add_books$', views.add_books, name='add_books'),
    url(r'^books/fav_book/(?P<id>\d+)$', views.fav_book, name="fav_book"),
]