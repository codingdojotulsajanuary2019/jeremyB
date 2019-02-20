from django.conf.urls import url
from . import views
                    
urlpatterns = [
    url(r'^$', views.index),
    url(r'^shows$', views.shows),
    url(r'^shows/new$', views.new),
    url(r'^shows/add_new$', views.add_new),
    url(r'^shows/(?P<id>\d+)$', views.single_show),
    url(r'^shows/(?P<id>\d+)/edit$', views.edit),
    url(r'^shows/(?P<id>\d+)/update$', views.update),
    url(r'^shows/(?P<id>\d+)/destroy', views.destroy)
]