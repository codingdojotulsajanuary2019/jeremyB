from django.conf.urls import url

from . import views

app_name = 'c1'

urlpatterns = [
    url(r'^$', views.index, name='index'),
    url(r'^register$', views.register),
    url(r'^dashboard$', views.dashboard, name='dashboard'),
    url(r'^users/(?P<uid>\d+)', views.show),
    url(r'^login$', views.login),
    url(r'^logout$', views.logout),
]
