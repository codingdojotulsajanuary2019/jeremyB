from django.conf.urls import url

from . import views

app_name = 'c3'

urlpatterns = [
    url(r'^$', views.index, name='index'),
    url(r'^register$', views.register),
    url(r'^dashboard$', views.dashboard, name='dashboard'),
    url(r'^login$', views.login),
    url(r'^logout$', views.logout, name='logout'),
    url(r'^messages/(?P<uid>\d+)', views.messages_create),
    url(r'^passwordrecovery', views.password_recovery, name='passwordrecover'),
    url(r'^emailreset', views.send_email),
    url(r'^passwordreset/(?P<email>[\w.%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4})', views.reset_password, name='passwordreset'),
    url(r'^submitreset/(?P<email>[\w.%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4})', views.submit_password_reset),
]
