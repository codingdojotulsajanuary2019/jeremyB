from django.conf.urls import url

from . import views

app_name = 'c2'

urlpatterns = [
    url(r'^$', views.index, name='index'),
    url(r'^register$', views.register),
    url(r'^dashboard$', views.dashboard, name='dashboard'),
    url(r'^login$', views.login),
    url(r'^logout$', views.logout, name='logout'),
    url(r'^(?P<uid>\d+)/edit', views.edit, name='edit'),
    url(r'^(?P<uid>\d+)/delete', views.destroy),
    url(r'^(?P<uid>\d+)', views.update),
]