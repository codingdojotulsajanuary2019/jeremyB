from django.conf.urls import url
from . import views

urlpatterns = [
    url(r'^trips$', views.trips, name='trips'),
    url(r'^trips/new', views.new, name='new'),
    url(r'^trips/create', views.create, name='create'),
    url(r'^trips/edit/(?P<id>\d+)', views.edit, name='edit'),
    url(r'^trips/edit/update', views.update, name='update'),
    url(r'^trips/delete/(?P<id>\d+)', views.delete, name='delete'),
    url(r'^trips/info/(?P<id>\d+)', views.info, name='info'),
    url(r'^trips/join/(?P<id>\d+)', views.join, name='join'),
    url(r'^trips/cancel/(?P<id>\d+)', views.cancel, name='cancel'),
]