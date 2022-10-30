SELECT A.MEMBER_NAME
     , B.REVIEW_TEXT
     , DATE_FORMAT(B.REVIEW_DATE, '%Y-%m-%d') AS REVIEW_DATE
  FROM MEMBER_PROFILE A
       INNER JOIN REST_REVIEW B ON B.MEMBER_ID = A.MEMBER_ID
  WHERE A.MEMBER_ID = (SELECT MEMBER_ID
                         FROM REST_REVIEW
                        GROUP BY MEMBER_ID           
                        ORDER BY COUNT(*) DESC
                        LIMIT 1)
 ORDER BY 
       REVIEW_DATE
     , REVIEW_TEXT
      