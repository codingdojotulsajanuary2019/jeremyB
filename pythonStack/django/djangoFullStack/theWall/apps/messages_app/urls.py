from django.conf.urls import url
from . import views

urlpatterns = [
    url(r'^wall$', views.wall, name='wall'),
    url(r'^message$', views.message, name='post_message'),
    url(r'^comment$', views.comment, name='post_comment'),
]