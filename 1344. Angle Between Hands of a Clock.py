class Solution:
    def angleClock(self, hour: int, minutes: int) -> float:
        # Calculate angle of hands in degrees 
        degreesHour = hour * 360 / 12 + (minutes / 60) * (360 / 12)
        degreesMinutes = minutes * 360 / 60
        
        # Reduce angle if greater than or equal to 360
        degreesHour = degreesHour % 360
        degreesMinutes = degreesMinutes % 360
        
        # Get the difference
        diff1 = abs(degreesHour - degreesMinutes)
        diff2 = 360 - abs(degreesHour - degreesMinutes)
        
        # Choose the smaller angle
        if diff1 < diff2:
            return diff1
        return diff2
