from django.conf.urls import url
from . import views

urlpatterns = [
    url(r'^whishes$', views.wishes, name='wishes'),
    url(r'^wishes/edit/(?P<id>\d+)', views.edit, name='edit'),
    url(r'^wishes/edit/update', views.update, name='update'),
    url(r'^wishes/new', views.new, name='new'),
    url(r'^wishes/create', views.create, name='create'),
    url(r'^wishes/delete/(?P<id>\d+)', views.delete, name='delete'),
    url(r'^wishes/stats', views.stats, name='stats'),
    url(r'^wishes/grant/(?P<id>\d+)', views.grant, name='grant'),
    url(r'^wishes/like/(?P<id>\d+)', views.like, name='like'),
]