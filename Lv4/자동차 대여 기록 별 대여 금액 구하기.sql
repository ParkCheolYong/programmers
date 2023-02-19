SELECT B.HISTORY_ID
     , CASE WHEN C.DISCOUNT_RATE IS NULL
            THEN A.DAILY_FEE * (B.DATE + 1)
            ELSE FLOOR(A.DAILY_FEE * (B.DATE + 1) * (1 - (C.DISCOUNT_RATE / 100))) 
       END AS FEE
  FROM CAR_RENTAL_COMPANY_CAR A
       INNER JOIN (SELECT HISTORY_ID
                        , CAR_ID
						, DATEDIFF(END_DATE, START_DATE) AS DATE
                        , CASE WHEN DATEDIFF(END_DATE, START_DATE) < 6 
						       THEN ''
							   WHEN DATEDIFF(END_DATE, START_DATE) < 29
							   THEN '7일 이상'
							   WHEN DATEDIFF(END_DATE, START_DATE) < 89
							   THEN '30일 이상'
							   ELSE '90일 이상'
						  END                            AS DURATION_TYPE
                     FROM CAR_RENTAL_COMPANY_RENTAL_HISTORY ) B ON B.CAR_ID = A.CAR_ID
	                                                           AND A.CAR_TYPE = '트럭'
       LEFT OUTER JOIN CAR_RENTAL_COMPANY_DISCOUNT_PLAN C ON C.DURATION_TYPE = B.DURATION_TYPE														                 AND C.CAR_TYPE = '트럭'
 ORDER BY 
       FEE DESC
     , B.HISTORY_ID DESC;