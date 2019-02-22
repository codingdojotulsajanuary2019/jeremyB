from django.db import models
from apps.login_app.models import User

# Create your models here.
class Message(models.Model):
    user_id = models.ForeignKey(User, related_name="poster")
    message = models.TextField()
    password = models.CharField(max_length=255)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

class Comment(models.Model):
    message_id = models.ForeignKey(Message, related_name="messages")
    user_id = models.ForeignKey(User, related_name="commenter")
    comment = models.TextField()
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)